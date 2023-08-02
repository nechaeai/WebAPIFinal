using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models;
namespace WebAPIFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            TeamMembers = Set<TeamMember>();
            FavoritePet = Set<FavoritePet>();
            FavoriteMovie = Set<FavoriteMovie>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoritePet>().HasData(
                new FavoritePet { Id = 1, Name = "Meow", Owner = "Nhi", Breed = "British Long Hair", DOB = new DateTime(2022, 05, 07), FavoriteFood = "Chicken Breast"},
                new FavoritePet { Id = 2, Name = "Zeus", Owner = "Samir", Breed = "Australian Shepherd", DOB = new DateTime(2010, 12, 18), FavoriteFood = "Peanut butter"}
            );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { Id = 1, MovieTitle = "Tetris", MovieGenre = "Biographical thriller", MovieDirector = "Jon S. Baird", ReleaseDate = new DateTime(2023, 03, 15)},
                new FavoriteMovie { Id = 2, MovieTitle = "To All the Boys I've Loved Before", MovieGenre = "Romance", MovieDirector = "Michael Fimognari", ReleaseDate = new DateTime(2018, 08, 17)},
                new FavoriteMovie { Id = 3, MovieTitle = "Into the Spider-verse", MovieGenre = "Action", MovieDirector = "Phill Lord, Chris Miller", ReleaseDate = new DateTime(2018, 12, 01)},
                new FavoriteMovie { Id = 4, MovieTitle = "The Terminal", MovieGenre = "Comedy/Drama", MovieDirector = "Tom Hanks", ReleaseDate = new DateTime(2004, 06, 18)}
            );
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoritePet> FavoritePet { get; set; }
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; }

    }
}