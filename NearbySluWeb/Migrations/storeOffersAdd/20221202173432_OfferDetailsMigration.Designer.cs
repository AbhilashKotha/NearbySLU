﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NearbySluWeb.Models;

#nullable disable

namespace NearbySluWeb.Migrations.storeOffersAdd
{
    [DbContext(typeof(storeOffersAddContext))]
    [Migration("20221202173432_OfferDetailsMigration")]
    partial class OfferDetailsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NearbySluWeb.Models.storeOffersAdd", b =>
                {
                    b.Property<int>("offerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("offerId"), 1L, 1);

                    b.Property<string>("Offer_Category")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Offer_Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Offer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Offer_Valid_upto")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("offerId");

                    b.ToTable("OffersDetails");
                });
#pragma warning restore 612, 618
        }
    }
}