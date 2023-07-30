﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIFinal.Data;

#nullable disable

namespace MyWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230730190949_FavPetMigration")]
    partial class FavPetMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("WebAPIFinal.Models.FavoritePet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("FavoriteFood")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FavoritePet");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Breed = "British Long Hair",
                            DOB = new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Chicken Breast",
                            Name = "Meow",
                            Owner = "Nhi"
                        },
                        new
                        {
                            Id = 2,
                            Breed = "Australian Shepherd",
                            DOB = new DateTime(2010, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Peanut butter",
                            Name = "Zeus",
                            Owner = "Samir"
                        },
                        new
                        {
                            Id = 3,
                            Breed = "Yorki",
                            DOB = new DateTime(2004, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Biscuits",
                            Name = "Moss",
                            Owner = "Shane"
                        },
                        new
                        {
                            Id = 4,
                            Breed = "Yorki",
                            DOB = new DateTime(2004, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Biscuits",
                            Name = "Moss",
                            Owner = "Shane"
                        });
                });

            modelBuilder.Entity("WebAPIFinal.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("YearInProgram")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
