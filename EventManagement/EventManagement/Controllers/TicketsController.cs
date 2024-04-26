using System.Security.Claims;
using EventManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IronBarCode;

namespace EventManagement.Controllers;

public class TicketsController : Controller
{
    private readonly ILogger<TicketsController> _logger;
    private readonly AppDBContext _context;
    public TicketsController(ILogger<TicketsController> logger, AppDBContext context)
    {
        _logger = logger;
        _context = context;
    }

    
    public async Task<IActionResult> Index()
    {
        TicketsIndexViewModel model = new TicketsIndexViewModel();

        if (User.IsInRole("User"))
        {
            string userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
            model.Tickets = await _context.Tickets
                .Where(a => a.UserId == userId)
                .Include(a => a.Event).ThenInclude(a => a.Venue)
                .OrderBy(a => a.Event.EventName)
                .ToListAsync();
        }
        else if (User.IsInRole("EventManager"))
        {
            string userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
            var events = await _context.Events
                .Where(a => a.UserId == userId)
                .ToListAsync();

            model.Tickets = await _context.Tickets
                .Where(a => events.Select(b => b.Id).Contains(a.EventId))
                .Include(a => a.Event).ThenInclude(a => a.Venue)
                .OrderBy(a => a.Event.EventName)
                .ToListAsync();
        }
        else if (User.IsInRole("Admin"))
        {
            model.Tickets = await _context.Tickets
                .Include(a => a.Event).ThenInclude(a => a.Venue)
                .OrderBy(a => a.Event.EventName)
                .ToListAsync();
        }

        return View(model);
    }


    public async Task<IActionResult> Cancel(string id)
    {
        Ticket ticket = null;
        if (User.IsInRole("User"))
        {
            ticket = _context.Tickets
                .Where(a => a.UserId == User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value && a.Id == id)
                .FirstOrDefault();

        }
        else if (User.IsInRole("Admin"))
        {
            ticket = _context.Tickets
                .Where(a => a.Id == id)
                .FirstOrDefault();
        }
        else
        {
            //If you are not a User or Admin, you cannot cancel a ticket
            return Unauthorized();
        }

        if (ticket == null)
        {
            return NotFound();
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ConfirmCancel(string id)
    {
        Ticket ticket = null;
        if (User.IsInRole("User"))
        {
            ticket = await _context.Tickets
                .Where(a => a.UserId == User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value && a.Id == id)
                .FirstOrDefaultAsync();

            if (ticket == null)
            {
                return NotFound();
            }

            ticket.Status = TickStat.CANCELLED;
            _context.Update(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        else if (User.IsInRole("Admin"))
        {
            ticket = await _context.Tickets
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if (ticket == null)
            {
                return NotFound();
            }

            ticket.Status = TickStat.CANCELLED;
            _context.Update(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        else
        {
            //If you are not a User or Admin, you cannot cancel a ticket
            return Unauthorized();
        }

        return View(nameof(Cancel));
    }

    [HttpGet]
    public async Task<IActionResult> Details(string id)
    {
        Ticket ticket = null;
        if (User.IsInRole("User"))
        {
            ticket = await _context.Tickets
                .Where(a => a.UserId == User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value && a.Id == id)
                .FirstOrDefaultAsync();
        }
        else if (User.IsInRole("Admin"))
        {
            ticket = await _context.Tickets
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();
        }
        else
        {
            //If you are not a User or Admin, you cannot view a ticket
            return Unauthorized();
        }
        if (ticket == null)
        {
            return NotFound();
        }
        return View(ticket);
    }

    public IActionResult Buy(string EventId)
    {
        var _event = _context.Events.SingleOrDefault(a => a.Id == EventId);
        if (_event == null)
        {
            return NotFound("Event with the provided Id could not be found!");
        }
        var _ticket = new Ticket
        {
            UserId = User.Claims.Single(a => a.Type == ClaimTypes.NameIdentifier).Value,
            EventId = EventId,
            type = TicketType.GENERAL,
            Status = TickStat.NONE,
            Id = Guid.NewGuid().ToString() + " " + DateTime.UtcNow.ToString("dd MMMM yyyy hh:mm:ss tt")
        };

        var model = new BuyTicketViewModel
        {
            Event = _event,
            ticket = _ticket,
            TypesOfTickets = new List<SelectListItem>(Enum.GetValues(typeof(TicketType)).Cast<TicketType>().Select(a => new SelectListItem(a.ToString(), ((int)a).ToString())))
        };

        return View(model);
    }


    [HttpPost]
    public async Task<IActionResult> ConfirmBuy(BuyTicketViewModel model)
    {
        if(ModelState.IsValid)
        {
            if (User.IsInRole("User"))
            {
                model.ticket.Price = model.ticket.CalcPriceCost();
                model.ticket.VAT = model.ticket.VatCost();
                model.ticket.Status = TickStat.CREATED_AND_AWAITING_PAYMENT;
                _context.Add(model.ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Payment), model.ticket.Id);
            }
            else
            {
                //Only Users can Buy A Ticket
                return Unauthorized();
            }
        }

        //Something went wrong if we reach this point...
        return View(nameof(Buy), model);
    }
    
    [Authorize]
    public async Task<IActionResult> Payment(string TicketId)
    {
        return View();
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> ConfirmPayment(string TicketId)
    {
        return View();
    }

    public async Task<GeneratedBarcode> GenerateTicketQrCode(string ticketId, string userId, string eventId, string ticketType)
    {
        
        // Generate a Simple BarCode image and save as PDF
        var qrCode = QRCodeWriter.CreateQrCode(
            $"TicketId: {ticketId} "+
            $"\nEventId: {eventId} " +
            $"\nUserId: {userId} " +
            $"\nType: {ticketType} ",
            500,
            QRCodeWriter.QrErrorCorrectionLevel.Medium);

        return qrCode;
    }

}
