﻿// <auto-generated />
using System;
using AdminApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdminApp.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("AdminApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(299),
                            Name = "Trousers",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(304)
                        },
                        new
                        {
                            Id = 2,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(309),
                            Name = "T-Shirts",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(311)
                        },
                        new
                        {
                            Id = 3,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(314),
                            Name = "Sweaters",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(316)
                        },
                        new
                        {
                            Id = 4,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(319),
                            Name = "Jackets",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(321)
                        },
                        new
                        {
                            Id = 5,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(324),
                            Name = "Accesories",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(326)
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNr")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Long str. 18-5",
                            City = "Berlin",
                            Country = "Germany",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(406),
                            Email = "a.jhones@gmail.com",
                            LastName = "Jhones",
                            Name = "Anthony",
                            PhoneNr = 45755362,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(409)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Long str. 18-5",
                            City = "London",
                            Country = "UK",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(416),
                            Email = "j.smiths@gmail.com",
                            LastName = "Smith",
                            Name = "Jack",
                            PhoneNr = 45755362,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(419)
                        },
                        new
                        {
                            Id = 3,
                            Address = "Long str. 18-5",
                            City = "New York",
                            Country = "US",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(422),
                            Email = "james.camerons@gmail.com",
                            LastName = "Cameron",
                            Name = "James",
                            PhoneNr = 45755362,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(425)
                        },
                        new
                        {
                            Id = 4,
                            Address = "Long str. 18-5",
                            City = "Madrid",
                            Country = "Spain",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(429),
                            Email = "carol.antuan@gmail.com",
                            LastName = "Antuanete",
                            Name = "Carolina",
                            PhoneNr = 45755362,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(432)
                        },
                        new
                        {
                            Id = 5,
                            Address = "Long str. 18-5",
                            City = "Rome",
                            Country = "Italy",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(435),
                            Email = "jess.benton@gmail.com",
                            LastName = "Benton",
                            Name = "Jesicca",
                            PhoneNr = 45755362,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(438)
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Vilnius str.",
                            City = "Vilnius",
                            Country = "Lithuania",
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(490),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(493)
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<int>("Supply")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("YearSalesTotal")
                        .HasColumnType("REAL");

                    b.Property<int>("YearTotalSoldUnits")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(85),
                            Description = "You can put it on your hand",
                            Name = "Bracelet",
                            Price = 14.99,
                            Rating = 4.2000000000000002,
                            Supply = 4478,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(121),
                            YearSalesTotal = 21675.540000000001,
                            YearTotalSoldUnits = 1446
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(130),
                            Description = "Perfectly balanced",
                            Name = "White T-Shirt",
                            Price = 21.989999999999998,
                            Rating = 3.6000000000000001,
                            Supply = 14889,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(131),
                            YearSalesTotal = 30324.330000000002,
                            YearTotalSoldUnits = 1335
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(134),
                            Description = "Good even for riding",
                            Name = "Denim Jeans",
                            Price = 35.0,
                            Rating = 4.9000000000000004,
                            Supply = 5874,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(136),
                            YearSalesTotal = 33320.0,
                            YearTotalSoldUnits = 952
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(139),
                            Description = "For cold winters",
                            Name = "Orange Sweater",
                            Price = 25.989999999999998,
                            Rating = 3.7999999999999998,
                            Supply = 1336,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(140),
                            YearSalesTotal = 20662.049999999999,
                            YearTotalSoldUnits = 795
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(142),
                            Description = "Casual wear",
                            Name = "Jeans jacket",
                            Price = 59.990000000000002,
                            Rating = 5.4000000000000004,
                            Supply = 4478,
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(144),
                            YearSalesTotal = 21675.540000000001,
                            YearTotalSoldUnits = 1446
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OfficeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(462),
                            Email = "admin.root@adminapp.com",
                            LastName = "Root",
                            Name = "Admin",
                            OfficeId = 1,
                            Role = "root",
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(465)
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            Cost = 255,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(354),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(357)
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 2,
                            Cost = 345,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(365),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(367)
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 1,
                            Cost = 399,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(370),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(373)
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 4,
                            Cost = 265,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(375),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(378)
                        },
                        new
                        {
                            Id = 5,
                            ClientId = 3,
                            Cost = 146,
                            CreateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(380),
                            UpdateDateTime = new DateTime(2023, 2, 6, 4, 17, 12, 485, DateTimeKind.Local).AddTicks(383)
                        });
                });

            modelBuilder.Entity("AdminApp.Models.Product", b =>
                {
                    b.HasOne("AdminApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdminApp.Models.Transaction", null)
                        .WithMany("Products")
                        .HasForeignKey("TransactionId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AdminApp.Models.Staff", b =>
                {
                    b.HasOne("AdminApp.Models.Office", "Office")
                        .WithMany("Staff")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });

            modelBuilder.Entity("AdminApp.Models.Transaction", b =>
                {
                    b.HasOne("AdminApp.Models.Client", "Client")
                        .WithMany("Transactions")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AdminApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AdminApp.Models.Client", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("AdminApp.Models.Office", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("AdminApp.Models.Transaction", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}