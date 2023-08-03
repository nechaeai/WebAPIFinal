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
            SpongeBobCharacter = Set<SpongeBobCharacter>();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Nhi Nguyen", Birthdate = new DateTime(1999, 8, 17), CollegeProgram = "Information Technology", YearInProgram = "Senior"},
                new TeamMember { Id = 2, FullName = "Samir Agrawal", Birthdate = new DateTime(2002, 3, 22), CollegeProgram = "Information Technology", YearInProgram = "sophmore" },
                new TeamMember { Id = 3, FullName = "Aleksei Nechaev", Birthdate = new DateTime(2001, 1, 7), CollegeProgram = "Information Technology", YearInProgram = "junior" },
                new TeamMember { Id = 4, FullName = "Shane Irvine", Birthdate = new DateTime(2003, 9, 26), CollegeProgram = "Information Technology", YearInProgram = "Freshman" }
            );
            modelBuilder.Entity<FavoritePet>().HasData(
                new FavoritePet { Id = 1, Name = "Meow", Owner = "Nhi", Breed = "British Long Hair", DOB = new DateTime(2022, 5, 7), FavoriteFood = "Chicken Breast"},
                new FavoritePet { Id = 2, Name = "Zeus", Owner = "Samir", Breed = "Australian Shepherd", DOB = new DateTime(2010, 12, 18), FavoriteFood = "Peanut butter"},
                new FavoritePet { Id = 3, Name = "Moss", Owner = "Shane", Breed = "Yorki", DOB = new DateTime(2004, 5, 26), FavoriteFood = "Biscuits"},
                new FavoritePet { Id = 4, Name = "Mischka", Owner = "Aleksei", Breed = "Cat", DOB = new DateTime(2022, 3, 7), FavoriteFood = "Butterflies"},
                new FavoritePet { Id = 5, Name = "Mock", Owner = "Vie", Breed = "Dog", DOB = new DateTime(2019, 8, 10), FavoriteFood = "Egg"}
            );
            modelBuilder.Entity<FavoriteMovie>().HasData(
                new FavoriteMovie { Id = 1, MovieTitle = "Tetris", MovieGenre = "Biographical thriller", MovieDirector = "Jon S. Baird", ReleaseDate = new DateTime(2023, 03, 15)},
                new FavoriteMovie { Id = 2, MovieTitle = "To All the Boys I've Loved Before", MovieGenre = "Romance", MovieDirector = "Michael Fimognari", ReleaseDate = new DateTime(2018, 08, 17)},
                new FavoriteMovie { Id = 3, MovieTitle = "Into the Spider-verse", MovieGenre = "Action", MovieDirector = "Phill Lord, Chris Miller", ReleaseDate = new DateTime(2018, 12, 01)},
                new FavoriteMovie { Id = 4, MovieTitle = "The Terminal", MovieGenre = "Comedy/Drama", MovieDirector = "Tom Hanks", ReleaseDate = new DateTime(2004, 06, 18)}
            );
            modelBuilder.Entity<SpongeBobCharacter>().HasData(
                new SpongeBobCharacter { Id = 1, Name = "Goofy Goober", Role = "Mascot", FirstAppearance = new DateTime(2004, 11, 19), VoicedBy = "Tim Blaney" },
                new SpongeBobCharacter { Id = 3, Name = "Patrick Star", Role = "SpongeBob's best friend", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Bill Fagerbakke" },
                new SpongeBobCharacter { Id = 4, Name = "Squidward Tentacles", Role = "SpongeBob's neighbor and coworker", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Rodger Bumpass" },
                new SpongeBobCharacter { Id = 5, Name = "Mr. Krabs", Role = "Owner of the Krusty Krab", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Clancy Brown" }
            );
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoritePet> FavoritePet { get; set; }
        public DbSet<FavoriteMovie> FavoriteMovie { get; set; }
        public DbSet<SpongeBobCharacter> SpongeBobCharacter { get; set; }

    }
}