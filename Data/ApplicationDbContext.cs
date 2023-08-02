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
            FavoriteRestaurants = Set<FavoriteRestaurants>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteRestaurants>().HasData(
                new FavoriteRestaurants { Id = 1, Name = "Fuji Steak House", Favorite Food = "volcano roll", location = "4389 Eastgate Square Dr Cincinnati OH", Last Visited = new DateTime(2023,07,01)},
                new FavoriteRestaurants { Id = 2, Name = "Cava", Favorite Food = "Grain bowl with grilled chicken", location = "13920 Old Saint Augustine Rd FL", Last Visited = new DateTime(2023, 07, 13) },
                new FavoriteRestaurants { Id = 3, Name = "Bibibop", Favorite Food = "Glass noodle bowl with BBQ beef", location = "228 Calhoun st Cincinnati OH", Last Visited = new DateTime(2023, 07, 27) },
                new FavoriteRestaurants { Id = 4, Name = "El Nopal", Favorite Food = "Quesadilla", location = "3218 Dixie Hwy Erlanger KY", Last Visited = new DateTime(2023, 07, 27)}
            );
            modelBuilder.Entity<FavoritePet>().HasData(
                new FavoritePet { Id = 1, Name = "Meow", Owner = "Nhi", Breed = "British Long Hair", DOB = new DateTime(2022, 5, 7), FavoriteFood = "Chicken Breast" },
                new FavoritePet { Id = 2, Name = "Zeus", Owner = "Samir", Breed = "Australian Shepherd", DOB = new DateTime(2010, 12, 18), FavoriteFood = "Peanut butter" },
                new FavoritePet { Id = 3, Name = "Moss", Owner = "Shane", Breed = "Yorki", DOB = new DateTime(2004, 5, 26), FavoriteFood = "Biscuits" },
                new FavoritePet { Id = 4, Name = "Mischka", Owner = "Aleksei", Breed = "Cat", DOB = new DateTime(2022, 3, 7), FavoriteFood = "Butterflies" },
                new FavoritePet { Id = 5, Name = "Mock", Owner = "Vie", Breed = "Dog", DOB = new DateTime(2019, 8, 10), FavoriteFood = "Egg" }
>>>>>>> 74c7a1f15edef097fb8fc9e969c5ae8f7554a71e
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoritePet> FavoritePet { get; set; }
        public DBSet<FavoriteRestaurants> FavoriteRestaurants { get; set; }

    }
}