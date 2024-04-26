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
    [Migration("20240426065636_Updates_On_Ticket_And_Event")]
    partial class Updates_On_Ticket_And_Event
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

                    b.Property<int>("EventStatus")
                        .HasColumnType("INTEGER");

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
                            Id = "a493dece-9a15-4c40-b226-e742eaaed0b224/04/26/06:56:35",
                            EventCategoryName = "Music"
                        },
                        new
                        {
                            Id = "2271e835-88b9-438a-a716-546481a0b24324/04/26/06:56:35",
                            EventCategoryName = "Sports"
                        },
                        new
                        {
                            Id = "cc2acece-c976-41ac-8232-11c9e0fdbb5924/04/26/06:56:35",
                            EventCategoryName = "Movies"
                        },
                        new
                        {
                            Id = "0cdbac8e-35f0-45e1-9a82-3063ee1d4fe324/04/26/06:56:35",
                            EventCategoryName = "Business"
                        },
                        new
                        {
                            Id = "c84fe682-60ec-40d3-8154-3d05ec62316124/04/26/06:56:35",
                            EventCategoryName = "Conference"
                        },
                        new
                        {
                            Id = "41a9cf17-a888-4ee7-a247-79ef1458996524/04/26/06:56:35",
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
                            Id = "0b5228fa-8d69-40f3-b878-788f876e7ee624/04/26/06:56:35",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "10f4f77f-ad5e-4207-86c4-b337a63b72d224/04/26/06:56:35",
                            RoleName = "User"
                        },
                        new
                        {
                            Id = "bd9406a2-f119-488f-9ceb-85b40d9946fc24/04/26/06:56:35",
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

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                            Id = "786ffce4-976f-4d14-98a7-271917114e1b24/04/26/06:56:35",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "admin@event-management.com",
                            Name = "Admin",
                            Password = "Admin@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "0b5228fa-8d69-40f3-b878-788f876e7ee624/04/26/06:56:35",
                            StreetAddress = "123 Eve st",
                            Surname = "User",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "015192bc-f4f0-42a4-bc09-0967bcf256a024/04/26/06:56:35",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "johndoe@event-management.com",
                            Name = "John",
                            Password = "Manager@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "bd9406a2-f119-488f-9ceb-85b40d9946fc24/04/26/06:56:35",
                            StreetAddress = "123 Eve st",
                            Surname = "Doe",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "4ff1992e-0c7f-4043-91bb-8ef9bcff3f7324/04/26/06:56:35",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "Sizwe@yahoo.com",
                            Name = "Sizwe",
                            Password = "User@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "10f4f77f-ad5e-4207-86c4-b337a63b72d224/04/26/06:56:35",
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
                            Id = "15f1d65a-445f-4b97-b456-3a558cbac71e24/04/26/06:56:35",
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
