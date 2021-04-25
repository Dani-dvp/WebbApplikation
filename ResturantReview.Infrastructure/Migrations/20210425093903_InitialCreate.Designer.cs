﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResturantReview.Infrastructure;

namespace ResturantReview.Infrastructure.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210425093903_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResturantReview.Domain.Models.Resturant", b =>
                {
                    b.Property<Guid>("ResturantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleMapsPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResturantLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResturantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResturantID");

                    b.ToTable("Resturants");
                });

            modelBuilder.Entity("ResturantReview.Domain.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("ResturantID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReviewTest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("ResturantID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ResturantReview.Domain.Models.Review", b =>
                {
                    b.HasOne("ResturantReview.Domain.Models.Resturant", "Resturant")
                        .WithMany("Reviews")
                        .HasForeignKey("ResturantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resturant");
                });

            modelBuilder.Entity("ResturantReview.Domain.Models.Resturant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
