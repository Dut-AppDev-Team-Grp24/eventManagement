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
    [Migration("20240426055532_Added_PricePerTicket_To_Events")]
    partial class Added_PricePerTicket_To_Events
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

                    b.Property<double>("PricePerTicket")
                        .HasColumnType("REAL");

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
                            Id = "822cfdd5-af39-4db8-8503-84efa4ff7f1724/04/26/05:55:31",
                            EventCategoryName = "Music"
                        },
                        new
                        {
                            Id = "20a38da5-7477-4172-bb4f-7306af9216c324/04/26/05:55:31",
                            EventCategoryName = "Sports"
                        },
                        new
                        {
                            Id = "6edfebe1-f940-4bd5-bd3a-92183bfe10d024/04/26/05:55:31",
                            EventCategoryName = "Movies"
                        },
                        new
                        {
                            Id = "aa9b3b1c-d436-4c0e-85a1-b6c04f3b807024/04/26/05:55:31",
                            EventCategoryName = "Business"
                        },
                        new
                        {
                            Id = "02210a9e-fa7a-4d67-9d07-1ec09db1900224/04/26/05:55:31",
                            EventCategoryName = "Conference"
                        },
                        new
                        {
                            Id = "e8169d3f-91c9-434f-bb58-1cd1821ce07724/04/26/05:55:31",
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
                            Id = "17437a65-9639-45da-b0a7-cf6e6cf487ef24/04/26/05:55:31",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "9c166ae9-6b57-4f90-aa76-eedf0a46d2f324/04/26/05:55:31",
                            RoleName = "User"
                        },
                        new
                        {
                            Id = "f211c319-4d80-448e-872c-d801121aec9b24/04/26/05:55:31",
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
                            Id = "92ad3fe7-c293-410e-b3ab-bb5cb09db03424/04/26/05:55:31",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "admin@event-management.com",
                            Name = "Admin",
                            Password = "Admin@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "17437a65-9639-45da-b0a7-cf6e6cf487ef24/04/26/05:55:31",
                            StreetAddress = "123 Eve st",
                            Surname = "User",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "394675d2-ec86-4adc-b5b0-c72439c7746f24/04/26/05:55:31",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "johndoe@event-management.com",
                            Name = "John",
                            Password = "Manager@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "f211c319-4d80-448e-872c-d801121aec9b24/04/26/05:55:31",
                            StreetAddress = "123 Eve st",
                            Surname = "Doe",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "6741b4b1-b1fe-4f19-b962-62be0055024424/04/26/05:55:31",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "Sizwe@yahoo.com",
                            Name = "Sizwe",
                            Password = "User@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "9c166ae9-6b57-4f90-aa76-eedf0a46d2f324/04/26/05:55:31",
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
                            Id = "9200301b-a839-4877-9d17-44743acd301d24/04/26/05:55:31",
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
