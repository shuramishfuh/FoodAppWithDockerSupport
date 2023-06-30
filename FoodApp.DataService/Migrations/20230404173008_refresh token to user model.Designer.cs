﻿// <auto-generated />
using System;
using FoodApp.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodApp.ORM.Migrations
{
    [DbContext(typeof(FoodAppContext))]
    [Migration("20230404173008_refresh token to user model")]
    partial class refreshtokentousermodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodApp.Models.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .IsFixedLength();

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__Address__3214EC0763C1B585");

                    b.HasIndex(new[] { "UserId" }, "IX_Address_UserId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("EmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("PhoneVerified")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RefreshTokenIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PK__AppUser__3214EC07EF43B5A3");

                    b.HasIndex(new[] { "Email" }, "UQ__AppUser__A9D105344E27A0A2")
                        .IsUnique();

                    b.ToTable("AppUser", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("Cvv")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("char(3)")
                        .IsFixedLength();

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("char(7)")
                        .IsFixedLength();

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Card__3214EC07ED0B8086");

                    b.HasIndex(new[] { "UserId" }, "IX_Card_UserId");

                    b.ToTable("Card", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id")
                        .HasName("PK__Item__3214EC078C28732B");

                    b.HasIndex(new[] { "MenuId" }, "IX_Item_MenuId");

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id")
                        .HasName("PK__Menu__3213E83F8F5ACDC5");

                    b.HasIndex(new[] { "RestaurantId" }, "IX_Menu_restaurant_id");

                    b.ToTable("Menu", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeliveryAddressId")
                        .HasColumnType("int");

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Order__3214EC071A796F60");

                    b.HasIndex("UserId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__OrderIte__3214EC0774719AF0");

                    b.HasIndex(new[] { "ItemId" }, "IX_OrderItem_ItemId");

                    b.HasIndex(new[] { "OrderId" }, "IX_OrderItem_OrderId");

                    b.ToTable("OrderItem", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Paypal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime>("TokenExpiration")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Paypal__3214EC07EF2C795E");

                    b.HasIndex(new[] { "UserId" }, "IX_Paypal_UserId");

                    b.ToTable("Paypal", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("CreatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.HasKey("Id")
                        .HasName("PK__Restaura__3214EC07558BF0F9");

                    b.ToTable("Restaurant", (string)null);
                });

            modelBuilder.Entity("FoodApp.Models.Models.Address", b =>
                {
                    b.HasOne("FoodApp.Models.Models.AppUser", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Address_AppUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Card", b =>
                {
                    b.HasOne("FoodApp.Models.Models.AppUser", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Card_AppUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Item", b =>
                {
                    b.HasOne("FoodApp.Models.Models.Menu", "Menu")
                        .WithMany("Items")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Item_Menu");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Menu", b =>
                {
                    b.HasOne("FoodApp.Models.Models.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Menu_Restaurant");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Order", b =>
                {
                    b.HasOne("FoodApp.Models.Models.AppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_AppUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodApp.Models.Models.OrderItem", b =>
                {
                    b.HasOne("FoodApp.Models.Models.Item", "IdNavigation")
                        .WithOne("OrderItem")
                        .HasForeignKey("FoodApp.Models.Models.OrderItem", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Item");

                    b.HasOne("FoodApp.Models.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_OrderItem_Order");

                    b.Navigation("IdNavigation");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Paypal", b =>
                {
                    b.HasOne("FoodApp.Models.Models.AppUser", "User")
                        .WithMany("Paypals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Paypal_AppUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodApp.Models.Models.AppUser", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cards");

                    b.Navigation("Orders");

                    b.Navigation("Paypals");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Item", b =>
                {
                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Menu", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodApp.Models.Models.Restaurant", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
