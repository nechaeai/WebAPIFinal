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
    [Migration("20230804014330_FavRestaurantsMig")]
    partial class FavRestaurantsMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("WebAPIFinal.Models.FavoriteMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieGenre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FavoriteMovie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieDirector = "Jon S. Baird",
                            MovieGenre = "Biographical thriller",
                            MovieTitle = "Tetris",
                            ReleaseDate = new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            MovieDirector = "Michael Fimognari",
                            MovieGenre = "Romance",
                            MovieTitle = "To All the Boys I've Loved Before",
                            ReleaseDate = new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            MovieDirector = "Phill Lord, Chris Miller",
                            MovieGenre = "Action",
                            MovieTitle = "Into the Spider-verse",
                            ReleaseDate = new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            MovieDirector = "Tom Hanks",
                            MovieGenre = "Comedy/Drama",
                            MovieTitle = "The Terminal",
                            ReleaseDate = new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

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
                            Breed = "Cat",
                            DOB = new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Butterflies",
                            Name = "Mischka",
                            Owner = "Aleksei"
                        },
                        new
                        {
                            Id = 5,
                            Breed = "Dog",
                            DOB = new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FavoriteFood = "Egg",
                            Name = "Mock",
                            Owner = "Vie"
                        });
                });

            modelBuilder.Entity("WebAPIFinal.Models.FavoriteRestaurants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Favorite_Food")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Last_Visited")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FavoriteRestaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Favorite_Food = "volcano roll",
                            Last_Visited = "2023,07,0",
                            Location = "4389 Eastgate Square Dr Cincinnati OH",
                            Name = "Fuji Steak House"
                        },
                        new
                        {
                            Id = 2,
                            Favorite_Food = "Grain bowl with grilled chicken",
                            Last_Visited = "2023, 07, 13",
                            Location = "13920 Old Saint Augustine Rd FL",
                            Name = "Cava"
                        },
                        new
                        {
                            Id = 3,
                            Favorite_Food = "Glass noodle bowl with BBQ beef",
                            Last_Visited = "2023, 07, 27",
                            Location = "228 Calhoun st Cincinnati OH",
                            Name = "Bibibop"
                        },
                        new
                        {
                            Id = 4,
                            Favorite_Food = "Quesadilla",
                            Last_Visited = "2023, 07, 27",
                            Location = "3218 Dixie Hwy Erlanger KY",
                            Name = "El Nopal"
                        });
                });

            modelBuilder.Entity("WebAPIFinal.Models.SpongeBobCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FirstAppearance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VoicedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SpongeBobCharacter");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstAppearance = new DateTime(2004, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Goofy Goober",
                            Role = "Mascot",
                            VoicedBy = "Tim Blaney"
                        },
                        new
                        {
                            Id = 3,
                            FirstAppearance = new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Patrick Star",
                            Role = "SpongeBob's best friend",
                            VoicedBy = "Bill Fagerbakke"
                        },
                        new
                        {
                            Id = 4,
                            FirstAppearance = new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Squidward Tentacles",
                            Role = "SpongeBob's neighbor and coworker",
                            VoicedBy = "Rodger Bumpass"
                        },
                        new
                        {
                            Id = 5,
                            FirstAppearance = new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mr. Krabs",
                            Role = "Owner of the Krusty Krab",
                            VoicedBy = "Clancy Brown"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1999, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Nhi Nguyen",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Samir Agrawal",
                            YearInProgram = "sophmore"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(2001, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Aleksei Nechaev",
                            YearInProgram = "junior"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(2003, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FullName = "Shane Irvine",
                            YearInProgram = "Freshman"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}