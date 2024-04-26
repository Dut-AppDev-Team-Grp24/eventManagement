using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EventManagement.Models;
using System.Security.Claims;

namespace EventManagement.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDBContext _context;
    private readonly IRepository<Event> _repository;

    public HomeController(ILogger<HomeController> logger, AppDBContext context)
    {
        _logger = logger;
        _context = context;
        _repository = new Repository<Event>(context);
    }

    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult EventManagerHome()
    {
        var userId = User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value;
        var model = new EventManagerHomeViewModel{
            Events = _context.Events.Where( a => a.UserId == userId).ToList()
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
