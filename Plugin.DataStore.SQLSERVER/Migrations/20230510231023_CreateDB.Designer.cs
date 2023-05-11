﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQLITE;

#nullable disable

namespace Plugin.DataStore.SQLSERVER.Migrations
{
    [DbContext(typeof(MarketDbContext))]
    [Migration("20230510231023_CreateDB")]
    partial class CreateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.BoughtProduct", b =>
                {
                    b.Property<Guid>("BoughtProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BoughtDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("BoughtPriceNewManat")
                        .HasColumnType("float");

                    b.Property<double>("BoughtPriceOldManat")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("BoughtProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("BoughtProduct");
                });

            modelBuilder.Entity("Shared.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Shared.Models.PaymentMethod", b =>
                {
                    b.Property<Guid>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentMethodName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BoughtPriceInNewManat")
                        .HasColumnType("float");

                    b.Property<double>("BoughtPriceInOldManat")
                        .HasColumnType("float");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<double>("DiscountInManat")
                        .HasColumnType("float");

                    b.Property<double>("PlusManat")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("SellPriceInNewManat")
                        .HasColumnType("float");

                    b.Property<double>("SellPriceInOldManat")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Shared.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BeforeQty")
                        .HasColumnType("float");

                    b.Property<string>("CashierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentMethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SoldQty")
                        .HasColumnType("float");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("ProductId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Shared.Models.BoughtProduct", b =>
                {
                    b.HasOne("Shared.Models.Product", "Product")
                        .WithMany("BoughtProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shared.Models.Category", b =>
                {
                    b.HasOne("Shared.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.HasOne("Shared.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shared.Models.Transaction", b =>
                {
                    b.HasOne("Shared.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Transactions")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.Models.Product", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shared.Models.Category", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shared.Models.PaymentMethod", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Navigation("BoughtProducts");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
