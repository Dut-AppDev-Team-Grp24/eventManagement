

using System.Net;
using EventManagement.Helper;
using EventManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Controllers;
public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private readonly JwtHelper _auth;
    private readonly Repository<User> _repository;
    private readonly AppDBContext _context;

    public AuthController(ILogger<AuthController> logger, JwtHelper auth,AppDBContext context)
    {
        _logger = logger;
        _auth = auth;
        _context = context;
        _repository = new Repository<User>(context);
    }


    public ActionResult LogIn()=> View();

    public ActionResult SignUp()
    {
        var model = new SigUpViewModel();
        if(model.AccountTypes == null) model.AccountTypes = new List<SelectListItem>();

        var accTypes = _context.Roles.ToList();
        foreach (var accType in accTypes)
        {
            if(!accType.RoleName.Contains("Admin"))
                model.AccountTypes.Add(new SelectListItem(accType.RoleName, accType.Id));
        }
        
        return View(model);
    }

    [HttpPost]
    public ActionResult LogIn(LoginViewModel model)
    {
        var user = _repository.Get(x => x.Email == model.Email);
        if (user != null && user.Password == model.Password)
        {
            string token = _auth.CreateAuthenticationTicket(user);
            HttpContext.Response.Cookies.Append("jwt-token", token);

            return RedirectToAction("Index","Home");
        }
        else
        {
            return View();
        }
    }

    [HttpPost]
    public ActionResult LogOut()
    {
        HttpContext.Response.Cookies.Delete("jwt-token");
        return RedirectToAction(nameof(LogIn), "Auth");
    }

    [HttpPost]
    public ActionResult SignUp(SigUpViewModel model)
    {
        if(ModelState.IsValid)
        {
            var user = new User{
                Id = Guid.NewGuid().ToString(),
                Name = model.Name,
                Password = model.Password,
                Surname = model.Surname,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                RoleId = model.RoleId,
                StreetAddress = model.StreetAddress,
                City = model.City,
                Province = model.Province,
                ZipCode = model.Province,
                Country = model.Country

            };

            _repository.Add(user);
            return RedirectToAction(nameof(LogIn), "Auth");
        }
        return View(model);
    }
}