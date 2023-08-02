using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class FavoriteMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MovieGenre = table.Column<string>(type: "TEXT", nullable: false),
                    MovieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMovie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoritePet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Owner = table.Column<string>(type: "TEXT", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FavoriteFood = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritePet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CollegeProgram = table.Column<string>(type: "TEXT", nullable: false),
                    YearInProgram = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "Id", "MovieDirector", "MovieGenre", "MovieTitle", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Jon S. Baird", "Biographical thriller", "Tetris", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Michael Fimognari", "Romance", "To All the Boys I've Loved Before", new DateTime(2018, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Phill Lord, Chris Miller", "Action", "Into the Spider-verse", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Tom Hanks", "Comedy/Drama", "The Terminal", new DateTime(2004, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FavoritePet",
                columns: new[] { "Id", "Breed", "DOB", "FavoriteFood", "Name", "Owner" },
                values: new object[,]
                {
                    { 1, "British Long Hair", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken Breast", "Meow", "Nhi" },
                    { 2, "Australian Shepherd", new DateTime(2010, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peanut butter", "Zeus", "Samir" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteMovie");

            migrationBuilder.DropTable(
                name: "FavoritePet");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
