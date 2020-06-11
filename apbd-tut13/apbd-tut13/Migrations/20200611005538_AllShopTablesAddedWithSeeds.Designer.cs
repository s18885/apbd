﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apbd_tut13.Entities;

namespace apbd_tut13.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20200611005538_AllShopTablesAddedWithSeeds")]
    partial class AllShopTablesAddedWithSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apbd_tut13.Entities.Confectionery", b =>
                {
                    b.Property<int>("IdConfectionery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<float>("PricePerItem")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdConfectionery")
                        .HasName("Confectionery_pk");

                    b.ToTable("Confectionery");

                    b.HasData(
                        new
                        {
                            IdConfectionery = 1,
                            Name = "ConName1",
                            PricePerItem = 10f,
                            Type = "ConType1"
                        },
                        new
                        {
                            IdConfectionery = 2,
                            Name = "ConName2",
                            PricePerItem = 20f,
                            Type = "ConType2"
                        },
                        new
                        {
                            IdConfectionery = 3,
                            Name = "ConName3",
                            PricePerItem = 30f,
                            Type = "ConType3"
                        });
                });

            modelBuilder.Entity("apbd_tut13.Entities.ConfectioneryOrder", b =>
                {
                    b.Property<int>("IdConfectionery")
                        .HasColumnType("int");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdConfectionery", "IdOrder")
                        .HasName("Confectionery_Order_pk");

                    b.HasIndex("IdOrder");

                    b.ToTable("Confectionery_Order");

                    b.HasData(
                        new
                        {
                            IdConfectionery = 1,
                            IdOrder = 1,
                            Notes = "ConOrderNotes1",
                            Quantity = 1
                        },
                        new
                        {
                            IdConfectionery = 2,
                            IdOrder = 2,
                            Notes = "ConOrderNotes2",
                            Quantity = 2
                        },
                        new
                        {
                            IdConfectionery = 3,
                            IdOrder = 3,
                            Notes = "ConOrderNotes3",
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("apbd_tut13.Entities.Customer", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdClient")
                        .HasName("Customer_pk");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            IdClient = 1,
                            Name = "CName1",
                            Surname = "CSurame1"
                        },
                        new
                        {
                            IdClient = 2,
                            Name = "CName2",
                            Surname = "CSurame2"
                        },
                        new
                        {
                            IdClient = 3,
                            Name = "CName3",
                            Surname = "CSurame3"
                        });
                });

            modelBuilder.Entity("apbd_tut13.Entities.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdEmployee")
                        .HasName("Employee_pk");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            IdEmployee = 1,
                            Name = "EName1",
                            Surname = "ESurame1"
                        },
                        new
                        {
                            IdEmployee = 2,
                            Name = "EName2",
                            Surname = "ESurame1"
                        },
                        new
                        {
                            IdEmployee = 3,
                            Name = "EName3",
                            Surname = "ESurame1"
                        });
                });

            modelBuilder.Entity("apbd_tut13.Entities.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateFinished")
                        .HasColumnType("date");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("IdOrder")
                        .HasName("Order_pk");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdEmployee");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            IdOrder = 1,
                            DateAccepted = new DateTime(2020, 5, 11, 2, 55, 38, 371, DateTimeKind.Local).AddTicks(2574),
                            DateFinished = new DateTime(2020, 6, 10, 2, 55, 38, 373, DateTimeKind.Local).AddTicks(8237),
                            IdClient = 1,
                            IdEmployee = 1,
                            Notes = "OrderNotes1"
                        },
                        new
                        {
                            IdOrder = 2,
                            DateAccepted = new DateTime(2020, 4, 11, 2, 55, 38, 373, DateTimeKind.Local).AddTicks(9973),
                            DateFinished = new DateTime(2020, 6, 9, 2, 55, 38, 373, DateTimeKind.Local).AddTicks(9996),
                            IdClient = 2,
                            IdEmployee = 2,
                            Notes = "OrderNotes2"
                        },
                        new
                        {
                            IdOrder = 3,
                            DateAccepted = new DateTime(2020, 3, 11, 2, 55, 38, 374, DateTimeKind.Local).AddTicks(27),
                            DateFinished = new DateTime(2020, 6, 8, 2, 55, 38, 374, DateTimeKind.Local).AddTicks(31),
                            IdClient = 3,
                            IdEmployee = 3,
                            Notes = "OrderNotes3"
                        });
                });

            modelBuilder.Entity("apbd_tut13.Entities.ConfectioneryOrder", b =>
                {
                    b.HasOne("apbd_tut13.Entities.Confectionery", "IdConfectioneryNavigation")
                        .WithMany("ConfectioneryOrder")
                        .HasForeignKey("IdConfectionery")
                        .HasConstraintName("Confectionery_Order_Confectionery")
                        .IsRequired();

                    b.HasOne("apbd_tut13.Entities.Order", "IdOrderNavigation")
                        .WithMany("ConfectioneryOrder")
                        .HasForeignKey("IdOrder")
                        .HasConstraintName("Confectionery_Order_Order")
                        .IsRequired();
                });

            modelBuilder.Entity("apbd_tut13.Entities.Order", b =>
                {
                    b.HasOne("apbd_tut13.Entities.Customer", "IdCustomerNavigation")
                        .WithMany("Order")
                        .HasForeignKey("IdClient")
                        .HasConstraintName("Order_Customer")
                        .IsRequired();

                    b.HasOne("apbd_tut13.Entities.Employee", "IdEmployeeNavigation")
                        .WithMany("Order")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("Order_Employee")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
