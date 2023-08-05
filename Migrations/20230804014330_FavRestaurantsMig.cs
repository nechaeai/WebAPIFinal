using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyWebApi.Migrations
{
    /// <inheritdoc />
    public partial class FavRestaurantsMig : Migration
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
                name: "FavoriteRestaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Favorite_Food = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Last_Visited = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteRestaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpongeBobCharacter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    FirstAppearance = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VoicedBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpongeBobCharacter", x => x.Id);
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
                    { 2, "Australian Shepherd", new DateTime(2010, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peanut butter", "Zeus", "Samir" },
                    { 3, "Yorki", new DateTime(2004, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biscuits", "Moss", "Shane" },
                    { 4, "Cat", new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butterflies", "Mischka", "Aleksei" },
                    { 5, "Dog", new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egg", "Mock", "Vie" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteRestaurants",
                columns: new[] { "Id", "Favorite_Food", "Last_Visited", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "volcano roll", "2023,07,0", "4389 Eastgate Square Dr Cincinnati OH", "Fuji Steak House" },
                    { 2, "Grain bowl with grilled chicken", "2023, 07, 13", "13920 Old Saint Augustine Rd FL", "Cava" },
                    { 3, "Glass noodle bowl with BBQ beef", "2023, 07, 27", "228 Calhoun st Cincinnati OH", "Bibibop" },
                    { 4, "Quesadilla", "2023, 07, 27", "3218 Dixie Hwy Erlanger KY", "El Nopal" }
                });

            migrationBuilder.InsertData(
                table: "SpongeBobCharacter",
                columns: new[] { "Id", "FirstAppearance", "Name", "Role", "VoicedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goofy Goober", "Mascot", "Tim Blaney" },
                    { 3, new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrick Star", "SpongeBob's best friend", "Bill Fagerbakke" },
                    { 4, new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squidward Tentacles", "SpongeBob's neighbor and coworker", "Rodger Bumpass" },
                    { 5, new DateTime(1999, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mr. Krabs", "Owner of the Krusty Krab", "Clancy Brown" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Nhi Nguyen", "Senior" },
                    { 2, new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Samir Agrawal", "sophmore" },
                    { 3, new DateTime(2001, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Aleksei Nechaev", "junior" },
                    { 4, new DateTime(2003, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Shane Irvine", "Freshman" }
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
                name: "FavoriteRestaurants");

            migrationBuilder.DropTable(
                name: "SpongeBobCharacter");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
