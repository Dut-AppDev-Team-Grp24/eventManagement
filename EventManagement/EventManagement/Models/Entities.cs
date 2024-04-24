using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models;

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

public class Role : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string RoleName { get; set; } 
}

public class Event  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
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

}

public class EventCategory  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id  { get; set; }

    public string EventCategoryName { get; set; }
}

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
    public string Price {get; set;}

    public List<Resource> Resources { get; set; }
}

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

public class Ticket  : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set;}
    public string EventId { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime ExpiryTime {get;set;}
    public TicketType Type {get;set;}
}