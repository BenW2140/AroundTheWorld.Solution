﻿// <auto-generated />
using System;
using AroundTheWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AroundTheWorld.Migrations
{
    [DbContext(typeof(AroundTheWorldContext))]
    [Migration("20200818221548_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AroundTheWorld.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Gothenburg",
                            Country = "Sweden"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "New York",
                            Country = "United States"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Pompeii",
                            Country = "Italy"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "York",
                            Country = "England"
                        });
                });

            modelBuilder.Entity("AroundTheWorld.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int?>("DestinationId");

                    b.Property<int>("Rating");

                    b.HasKey("ReviewId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "The furniture was amazing",
                            DestinationId = 1,
                            Rating = 9
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "Nothing like the original",
                            DestinationId = 2,
                            Rating = 3
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "As someone who used to live there, its seen better days",
                            DestinationId = 3,
                            Rating = 2
                        },
                        new
                        {
                            ReviewId = 4,
                            Description = "Classic",
                            DestinationId = 4,
                            Rating = 6
                        });
                });

            modelBuilder.Entity("AroundTheWorld.Models.Review", b =>
                {
                    b.HasOne("AroundTheWorld.Models.Destination")
                        .WithMany("Reviews")
                        .HasForeignKey("DestinationId");
                });
#pragma warning restore 612, 618
        }
    }
}
