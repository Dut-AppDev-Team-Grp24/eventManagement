using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EventManagement.Models
{
    public partial class AppDBContext : DbContext
    {


        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
            
        }

       

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string AdminId = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
              regUser = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
              eventManager = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss");

            modelBuilder.Entity<Role>().HasData(
              new Role { Id = AdminId, RoleName = "Admin" },
              new Role { Id = regUser, RoleName = "User" },
              new Role { Id = eventManager, RoleName = "EventManager" }
            );

            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                  Name = "Admin",
                  Surname = "User",
                  Email = "admin@event-management.com",
                  Password = "Admin@123",
                  RoleId = AdminId,

                  PhoneNumber = "071231234",

                  StreetAddress = "123 Eve st",
                  City = "Durban",
                  Province = "KwaZulu-Natal",
                  ZipCode = "4000",
                  Country = "South Africa"
              },
              new User
              {
                  Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                  Name = "John",
                  Surname = "Doe",
                  Email = "johndoe@event-management.com",
                  Password = "Manager@123",
                  PhoneNumber = "071231234",

                  StreetAddress = "123 Eve st",
                  City = "Durban",
                  Province = "KwaZulu-Natal",
                  ZipCode = "4000",
                  Country = "South Africa",

                  RoleId = eventManager
              },
              new User
              {
                  Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                  Name = "Sizwe",
                  Surname = "Mchunu",
                  Email = "Sizwe@yahoo.com",
                  Password = "User@123",

                  PhoneNumber = "071231234",

                  StreetAddress = "123 Eve st",
                  City = "Durban",
                  Province = "KwaZulu-Natal",
                  ZipCode = "4000",
                  Country = "South Africa",

                  RoleId = regUser
              }
            );

            modelBuilder.Entity<EventCategory>().HasData(
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Music"
                },
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Sports"
                },
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Movies"
                },
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Business"
                },
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Conference"
                },
                new EventCategory{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    EventCategoryName = "Food & Drinks"
                }
            );

            modelBuilder.Entity<Venue>().HasData(
                new Venue{
                    Id = Guid.NewGuid().ToString() + DateTime.UtcNow.ToString("yy/MM/dd/HH:mm:ss"),
                    VenueName = "Lion Park Safari Lodge & Conference Center",
                    VenueDescription = "Lion Park Safari Lodge & Conference Center",
                    VenueCapacity = 250,
                    StreetAddress = "123 Eve st",
                    City = "Durban",
                    Province = "KwaZulu-Natal",
                    Country = "South Africa",
                    ZipCode = "4000",
                    Price = 500,
                    VenuePictureUrl = "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png"
                }
            );
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventPromotion> EventPromotions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Payment> Payment { get; set; }

    }
}
