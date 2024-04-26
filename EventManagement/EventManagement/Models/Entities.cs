using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models;


#region User
public class User : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Password {get; set; }
    public string Surname{get;set;}
    public string Email { get; set;}
    public string PhoneNumber{get; set;}
    public string RoleId {get;set;}

    //Address Fields
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string Province {get;set;}
    public string ZipCode { get; set; }
    public string Country { get; set; }
}
#endregion

#region Role
public class Role : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string RoleName { get; set; } 
}
#endregion

#region Event
public class Event  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
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
    public double PricePerTicket { get; set; }

    [Required]
    public string EventCategoryId  { get; set; }

    [Required]
    public string VenueId { get; set; }

    [Required]
    public stat EventStatus { get; set; }

    public string ImageUrl {get;set;}

    public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();
    [ForeignKey("VenueId")]
    public virtual Venue Venue { get; set; }
    [ForeignKey("UserId")]
    public virtual User User{get;set;}
    [ForeignKey("EventCategoryId")]
    public virtual EventCategory EventCategory{get;set;}
}
#endregion

#region EventCategory
public class EventCategory  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id  { get; set; }

    public string EventCategoryName { get; set; }
}
#endregion

#region Venue
public class Venue  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string VenueName { get; set; }
    public string VenueDescription { get; set; }
    public string VenuePictureUrl { get; set; }
    //Address Fields
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string Province {get;set;}
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public double Price {get; set;}
    public int VenueCapacity {get;set;}
  
    public List<Resource> Resources { get; set; }


     
    #region Calculation
    public AppDBContext _db;
    public Venue()
    {
        DbContextOptionsBuilder<AppDBContext> opt = new DbContextOptionsBuilder<AppDBContext>();
        opt.UseSqlite("Data Source=Data/EventManagementDb.db");

        _db = new AppDBContext(opt.Options);
    }

    public List<Resource> GetResourcesForVenue(string venueId)
    {
        return _db.Resources.Where(v => v.Id == venueId).ToList();
    }

    // Method to calculate the total price of resources with an increment
    public double CalculateTotalPrice(string venueId)
    {
        var resources = GetResourcesForVenue(venueId);
        double totalPrice = 0;

        // Calculate total price using foreach loop
        foreach (var resource in resources)
        {
            totalPrice += resource.Price;
        }

        return totalPrice;
    }

    #endregion


}
#endregion

#region Resource
public class Resource  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
    public string ResourceName { get; set; }
    public string ResourceDescription { get; set; }
    public string ResourcePictureUrl { get; set; }
    public string ResourceType{ get; set; }
    public double Price {get;set;}
}
#endregion
#region EventPromotion
public class EventPromotion  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
    public string EventId { get; set; }
    public string socialLink { get; set; }
    public string Title { get; set; }
    public string Description{get;set;}
    public string PhotoUrl { get; set; }
}
#endregion

#region Payment
public class Payment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
    public string EventIdOrTicketId { get; set; }
    public string UserId {get;set;}
    public string ItemName { get; set; }
    public string ItemQuantity {get;set;}
    public double TotalAmount { get; set; }
}
#endregion

#region Ticket
public class Ticket  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
    public string UserId {get;set;}
    public string EventId { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime ExpiryTime {get;set;}
    public TicketType type {get;set;}
    public double Price { get; set; }
    public TickStat Status { get; set; } = TickStat.NONE;

    public double Commission { get; set; } = 30;
    public double VAT { get; set; }

    [ForeignKey("UserId")]
    public virtual User User{get;set;}
    [ForeignKey("EventId")]
    public virtual Event Event{get;set;}
 
 
    #region initialise Database
    private AppDBContext _db;
   
    public Ticket(AppDBContext db)
    {
        _db = db;
    }

    public Ticket ()
    {
        DbContextOptionsBuilder<AppDBContext> opt = new DbContextOptionsBuilder<AppDBContext>();
        opt.UseSqlite("Data Source=Data/EventManagementDb.db");

        _db = new AppDBContext(opt.Options);
    }
    #endregion

    #region Ticket Price Calculation
    //Linq statement that pull Price per cost in the event table
    public double PullPricePer()
    {
        var tp=(from t in _db.Events
                where t.Id == Id
                select t.PricePerTicket).FirstOrDefault();

        return tp;
    }
    // Ticket cost method
    public double CalcPriceCost()
    {
        double commission = 30;
        if (type == TicketType.VVIP)
        {
            Price = (PullPricePer() * 0.15) + VatCost() + commission;
        }
        else if (type == TicketType.VIP)
        {
            Price = (PullPricePer() * 0.1) + VatCost() + commission;
        }
        else
        {
            Price = PullPricePer()+VatCost()+commission;
        }
        return Price;
    }

    //Commision cost
    public double VatCost()
    {
        double vat = PullPricePer() * 0.15;
        return vat;
    }

    #endregion

}
#endregion

#region Booking
public class Booking
{
    [Key]
    public string BookingId { get; set; }
    public string EventId { get; set; }
    public string UserId { get; set; }
   
    [DisplayName("Total Cost")]
    public double FinalCost { get; set; }

    public TickStat Status { get; set; }

    [ForeignKey("EventId")]
    public virtual Event Event { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }

}
#endregion