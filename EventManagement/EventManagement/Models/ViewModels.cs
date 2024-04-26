using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventManagement.Models;

#region LoginViewModel
public class LoginViewModel
{
    public string Email{get;set;}
    public string Password{get;set;}

}
#endregion

#region SigUpViewModel
public class SigUpViewModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Password {get; set; }
    [Required]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword {get; set; }
    [Required]
    public string Surname{get;set;}
    [Required]
    public string Email { get; set;}
    [Required]
    public string PhoneNumber{get; set;}
    [Required]
    public string RoleId {get;set;}

    //Address Fields
    [Required]
    public string StreetAddress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Province {get;set;}
    [Required]
    public string ZipCode { get; set; }
    [Required]
    public string Country { get; set; }


    public List<SelectListItem> AccountTypes{get;set;} = new List<SelectListItem>();
}
#endregion

#region  EventViewModel
public class EventViewModel
{
    public string Id {get; set;}
    [Required]
    public string UserId{get; set;}

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime StartTime { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime EndTime { get; set; }

    [Required]
    public string EventName { get; set;}

    [Required]
    public string EventDescription { get; set;}

    [Required]
    public string EventCategoryId  { get; set; }

    [Required]
    public string VenueId { get; set; }

    public IFormFile EventPoster {get;set;}

    public double PricePerTicket {get;set;}

    //DropDownLists
    public List<SelectListItem> EventCategories {get;set;} = new List<SelectListItem>();
    public List<SelectListItem> Venues { get; set; } = new List<SelectListItem>();
    public stat EventStatus { get; internal set; }
}
#endregion 

#region EventManagerHomeViewModel
public class EventManagerHomeViewModel
{
    public List<Event> Events { get; set; }
}
#endregion

#region BuyTicketViewModel
public class BuyTicketViewModel
{
    public Ticket ticket { get; set; }
    public Event Event { get; internal set; }
    public List<SelectListItem> TypesOfTickets { get; internal set; } = new List<SelectListItem>();
}
#endregion

#region TicketsIndexViewModel
public class TicketsIndexViewModel
{
    public List<Ticket> Tickets { get; set; } = new List<Ticket>();
}
#endregion

