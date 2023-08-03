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
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Nhi Nguyen", Birthdate = new DateTime(1999, 8, 17), CollegeProgram = "Information Technology", YearInProgram = "Senior"},
                new TeamMember { Id = 2, FullName = "Samir Agrawal", Birthdate = new DateTime(2002, 3, 22), CollegeProgram = "Information Technology", YearInProgram = "sophmore" },
                new TeamMember { Id = 3, FullName = "Aleksei Nechaev", Birthdate = new DateTime(2001, 1, 7), CollegeProgram = "Information Technology", YearInProgram = "junior" },
                new TeamMember { Id = 4, FullName = "Shane Irvine", Birthdate = new DateTime(2003, 9, 26), CollegeProgram = "Information Technology", YearInProgram = "Freshman" }
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