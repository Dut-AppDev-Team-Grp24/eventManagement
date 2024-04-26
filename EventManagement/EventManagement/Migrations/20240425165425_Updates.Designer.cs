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
    [Migration("20240425165425_Updates")]
    partial class Updates
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
                            Id = "1d111f0f-29cb-4ffd-bbf3-8b90644a290124/04/25/16:54:25",
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "01a54960-26f7-45ae-a28e-fdac3541e1f524/04/25/16:54:25",
                            RoleName = "User"
                        },
                        new
                        {
                            Id = "856715fe-f516-4fbd-974b-831d31923f5024/04/25/16:54:25",
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
                            Id = "ddd1490a-7033-4ab3-8660-b62ae660ca8524/04/25/16:54:25",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "admin@event-management.com",
                            Name = "Admin",
                            Password = "Admin@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "1d111f0f-29cb-4ffd-bbf3-8b90644a290124/04/25/16:54:25",
                            StreetAddress = "123 Eve st",
                            Surname = "User",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "27e31126-0fee-4068-9074-d79bc80fd30a24/04/25/16:54:25",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "johndoe@event-management.com",
                            Name = "John",
                            Password = "Manager@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "856715fe-f516-4fbd-974b-831d31923f5024/04/25/16:54:25",
                            StreetAddress = "123 Eve st",
                            Surname = "Doe",
                            ZipCode = "4000"
                        },
                        new
                        {
                            Id = "e821e7a2-7bfb-4eba-a1f2-70b02b39412e24/04/25/16:54:25",
                            City = "Durban",
                            Country = "South Africa",
                            Email = "Sizwe@yahoo.com",
                            Name = "Sizwe",
                            Password = "User@123",
                            PhoneNumber = "071231234",
                            Province = "KwaZulu-Natal",
                            RoleId = "01a54960-26f7-45ae-a28e-fdac3541e1f524/04/25/16:54:25",
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

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
