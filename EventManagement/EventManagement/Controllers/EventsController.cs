using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EventManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Controllers;

public class EventsController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDBContext _context;
    private readonly IRepository<Event> _repository;
    private readonly AzureBlobRepository _blobRepository;

    public EventsController(
        ILogger<HomeController> logger,
        AppDBContext context, AzureBlobRepository blobRepository)
    {
        _logger = logger;
        _context = context;
        _repository = new Repository<Event>(context);
        _blobRepository = blobRepository;
    }

    public IActionResult Index()
    {
        var Items = _context.Events.ToList();
        return View(Items);
    }

    public IActionResult Create()
    {
        var Venues = _context.Venues.ToList();
        var EventCategories = _context.EventCategories.ToList();
        var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
        var Event = new EventViewModel
        {
            Id = Guid.NewGuid().ToString(),
            UserId = userId != null ? userId : "",
        };

        if (Venues != null)
        {
            foreach (var venue in Venues)
            {
                Event.Venues.Add(new SelectListItem(venue.VenueName, venue.Id.ToString()));
            }
        }

        if (EventCategories != null)
        {
            foreach (var category in EventCategories)
            {
                Event.EventCategories.Add(new SelectListItem(category.EventCategoryName, category.Id.ToString()));
            }
        }


        return View(Event);
    }

    [HttpPost]
    public async Task<ActionResult> Create(EventViewModel model)
    {

        var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;

        if (userId != null)
        {
            model.UserId = userId;
        }

        if (ModelState.IsValid)
        {
            var blobClient = await _blobRepository.UploadBlobAsync(model.EventPoster);

            if (blobClient == null)
                throw new Exception("[!]'POST: Events/Create' Failed; Reason Could Not Upload Image to Server!");

            var Event = new Event
            {
                Id = string.IsNullOrEmpty(model.Id) ? Guid.NewGuid().ToString() : model.Id,
                UserId = model.UserId,
                EventName = model.EventName,
                EventDescription = model.EventDescription,
                VenueId = model.VenueId,
                EventCategoryId = model.EventCategoryId,
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                ImageUrl = blobClient.Uri.AbsoluteUri,
                PricePerTicket = model.PricePerTicket,
                EventStatus = stat.CREATED_AND_AWAITING_PAYMENT
            };

            await _context.Events.AddAsync(Event);
            await _context.SaveChangesAsync();
            return RedirectToAction("EventManagerHome", "Home");
        }

        #region Failed_To_Create_Event
        //if we reach here something wrong happened
        //Prepare the DropdownList Items
        var Venues = _context.Venues.ToList();
        var EventCategories = _context.EventCategories.ToList();
        if (Venues != null)
        {
            foreach (var venue in Venues)
            {
                model.Venues.Add(new SelectListItem(venue.VenueName, venue.Id.ToString()));
            }
        }

        if (EventCategories != null)
        {
            foreach (var category in EventCategories)
            {
                model.EventCategories.Add(new SelectListItem(category.EventCategoryName, category.Id.ToString()));
            }
        }
        return View(model);
        #endregion

    }

    public async Task<IActionResult> Details(string id)
    {
        var model = await _context.Events.FindAsync(id);

        if (model == null)
        {
            return NotFound();
        }
        return View(model);
    }

    public IActionResult Edit(string id)
    {
        var Venues = _context.Venues.ToList();
        var EventCategories = _context.EventCategories.ToList();
        var model = _context.Events.Where(a => a.Id == id).FirstOrDefault();

        var Event = new EventViewModel
        {
            Id = model.Id,
            UserId = model.UserId,
            EventName = model.EventName,
            EventDescription = model.EventDescription,
            VenueId = model.VenueId,
            EventCategoryId = model.EventCategoryId,
            StartTime = model.StartTime,
            EndTime = model.EndTime,
            PricePerTicket = model.PricePerTicket,
            EventStatus = model.EventStatus
        };

        if (Venues != null)
        {
            foreach (var venue in Venues)
            {
                Event.Venues.Add(new SelectListItem(venue.VenueName, venue.Id.ToString()));
            }
        }

        if (EventCategories != null)
        {
            foreach (var category in EventCategories)
            {
                Event.EventCategories.Add(new SelectListItem(category.EventCategoryName, category.Id.ToString()));
            }
        }


        return View(Event);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EventViewModel model)
    {
        if (ModelState.IsValid)
        {
            var Event = _context.Events.Where(a => a.Id == model.Id).FirstOrDefault();
            Event.Id = model.Id;
            Event.UserId = model.UserId;
            Event.EventName = model.EventName;
            Event.EventDescription = model.EventDescription;
            Event.VenueId = model.VenueId;
            Event.EventCategoryId = model.EventCategoryId;
            Event.StartTime = model.StartTime;
            Event.EndTime = model.EndTime;
            Event.PricePerTicket = model.PricePerTicket;
            await _context.SaveChangesAsync();
            return RedirectToAction("EventManagerHome", "Home");
        }
        return View(model);
    }

    public async Task<IActionResult> Cancel(string id)
    {
        var Event = await _context.Events.Where(a => a.Id == id).FirstOrDefaultAsync();
        if (Event == null)
            throw new Exception("Failed To find Event with ID: " + id);

        return View(Event);
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmCancel(string id)
    {
        var Event = _context.Events.Where(a => a.Id == id).FirstOrDefault();
        Event.EventStatus = stat.CANCELLED;
        await _context.SaveChangesAsync();

        Task backgroundTask = Task.Run(async () =>
        {
            await ProcessRefundsForCanceledEvent(Event);
        });

        await backgroundTask;

        return RedirectToAction("EventManagerHome", "Home");
    }

    public async Task ProcessRefundsForCanceledEvent(Event Event)
    {
        // Retrieve the list of people who bought tickets for the canceled event
        var tickets = _context.Tickets.Where(t => t.EventId == Event.Id).ToList();

        // Create and start a background task to process refunds
        Task refundTask = Task.Run(async () =>
        {
            foreach (var ticket in tickets)
            {
                // Process refund for each ticket holder
                await ProcessRefundAsync(ticket.UserId, ticket.type, Event);
            }
        });

        // Wait for the refund task to complete without blocking the main thread
        await refundTask;
    }

    private async Task ProcessRefundAsync(string userId, TicketType type, Event Event)
    {
        //Todo: Implement refund processing
        await Task.Delay(2000); // 2 seconds delay for simulation
    }
}
