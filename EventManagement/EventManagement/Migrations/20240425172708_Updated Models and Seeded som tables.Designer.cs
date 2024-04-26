﻿// <auto-generated />
using System;
using EventManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventManagement.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240425172708_Updated Models and Seeded som tables")]
    partial class UpdatedModelsandSeededsomtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("EventManagement.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventCategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventManagement.Models.EventCategory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EventCategories");

                    b.HasData(
                        new
                        {
                            Id = "5b7feecf-e65e-4b85-9237-c4a44254c9ec24/04/25/17:27:07",
                            EventCategoryName = "Music"
                        },
                        new
                        {
                            Id = "20fc4757-7c97-47d5-90cb-ef70b251f26d24/04/25/17:27:07",
                            EventCategoryName = "Sports"
                        },
                        new
                        {
                            Id = "dc74c252-920a-413b-9f30-601fcebaf85a24/04/25/17:27:07",
                            EventCategoryName = "Movies"
                        },
                        new
                        {
                            Id = "e16b703f-7f39-4faa-82a4-1487eb940de124/04/25/17:27:07",
                            EventCategoryName = "Business"
                        },
                        new
                        {
                            Id = "f9f412a1-0fb1-4d60-a51f-aab8e7d96a6324/04/25/17:27:07",
                            EventCategoryName = "Conference"
                        },
                        new
                        {
                            Id = "5fa0c2e1-9c6e-4850-9356-0ba89d89e02324/04/25/17:27:07",
                            EventCategoryName = "Food & Drinks"
                        });
                });

            modelBuilder.Entity("EventManagement.Models.EventPromotion", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("socialLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EventPromotions");
                });

            modelBuilder.Entity("EventManagement.Models.Payment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventIdOrTicketId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemQuantity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("REAL");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("EventManagement.Models.Resource", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ResourceDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourcePictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("EventManagement.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "2583357e-4089-44e5-a315-eaf22404c37024/04/25/17:27:07",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "a302caf0-de8c-4b70-83f2-59f400bdf38124/04/25/17:27:07",
                            RoleName = "User"
                        },
                        new
                        {
                            Id = "c71c7110-175e-4eea-85fb-0f52a31fdba524/04/25/17:27:07",
                            RoleName = "EventManager"
                        });
                });

            modelBuilder.Entity("EventManagement.Models.Ticket", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiryTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("EventManagement.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "e2580668-825a-4a5a-960f-87c1e11347ec24/04/25/17:27:07",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "admin@event-management.com",
                            Name = "Admin",
                            Password = "Admin@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "2583357e-4089-44e5-a315-eaf22404c37024/04/25/17:27:07",
                            StreetAddress = "123 Eve st",
                            Surname = "User",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "a07a08a9-798f-4b66-a21c-086df38d823a24/04/25/17:27:07",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "johndoe@event-management.com",
                            Name = "John",
                            Password = "Manager@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "c71c7110-175e-4eea-85fb-0f52a31fdba524/04/25/17:27:07",
                            StreetAddress = "123 Eve st",
                            Surname = "Doe",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "2a8eaeee-fec3-4867-9a3e-9cc7a7a9564724/04/25/17:27:07",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "Sizwe@yahoo.com",
                            Name = "Sizwe",
                            Password = "User@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "a302caf0-de8c-4b70-83f2-59f400bdf38124/04/25/17:27:07",
                            StreetAddress = "123 Eve st",
                            Surname = "Mchunu",
                            ZipCode = "4000"
                        });
                });

            modelBuilder.Entity("EventManagement.Models.Venue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VenueCapacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VenueDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VenuePictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            Id = "1018c2a8-faf7-4342-875e-2a0de2639e8c24/04/25/17:27:07",
                            City = "Durban",
                            Country = "South Africa",
                            Price = 500.0,
                            Province = "KwaZulu-Natal",
                            StreetAddress = "123 Eve st",
                            VenueCapacity = 250,
                            VenueDescription = "Lion Park Safari Lodge & Conference Center",
                            VenueName = "Lion Park Safari Lodge & Conference Center",
                            VenuePictureUrl = "https://lionandsafaripark.com/wp-content/uploads/2020/02/venue-functions2.png",
                            ZipCode = "4000"
                        });
                });

            modelBuilder.Entity("EventManagement.Models.Resource", b =>
                {
                    b.HasOne("EventManagement.Models.Venue", null)
                        .WithMany("Resources")
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("EventManagement.Models.Venue", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
