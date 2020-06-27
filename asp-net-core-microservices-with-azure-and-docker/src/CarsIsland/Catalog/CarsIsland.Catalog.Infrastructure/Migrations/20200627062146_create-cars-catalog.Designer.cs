﻿// <auto-generated />
using System;
using CarsIsland.Catalog.Infrastructure.Services.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarsIsland.Catalog.Infrastructure.Migrations
{
    [DbContext(typeof(CarCatalogDbContext))]
    [Migration("20200627062146_create-cars-catalog")]
    partial class createcarscatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarsIsland.Catalog.Domain.Model.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AvailableForRent")
                        .HasColumnType("bit");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerWeek")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca617122-b8d1-4f1d-97e7-07fb6fc15a1a"),
                            AvailableForRent = true,
                            Brand = "BMW",
                            Model = "320",
                            PricePerDay = 200m,
                            PricePerMonth = 2000m,
                            PricePerWeek = 900m
                        },
                        new
                        {
                            Id = new Guid("6c174c4b-d9fe-4030-945c-2f17816414a2"),
                            AvailableForRent = true,
                            Brand = "Audi",
                            Model = "A1",
                            PricePerDay = 120m,
                            PricePerMonth = 1600m,
                            PricePerWeek = 700m
                        },
                        new
                        {
                            Id = new Guid("fc0a3062-3383-4bfa-8a47-7abb6dac7782"),
                            AvailableForRent = true,
                            Brand = "Mercedes",
                            Model = "E200",
                            PricePerDay = 250m,
                            PricePerMonth = 2600m,
                            PricePerWeek = 1100m
                        },
                        new
                        {
                            Id = new Guid("edb3fdcb-8a08-46df-94c3-695310ad807c"),
                            AvailableForRent = true,
                            Brand = "Ford",
                            Model = "Focus",
                            PricePerDay = 90m,
                            PricePerMonth = 1000m,
                            PricePerWeek = 400m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
