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
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoritePet>().HasData(
                new FavoritePet { Id = 1, Name = "Meow", Owner = "Nhi", Breed = "British Long Hair", DOB = new DateTime(2022, 5, 7), FavoriteFood = "Chicken Breast"},
                new FavoritePet { Id = 2, Name = "Zeus", Owner = "Samir", Breed = "Australian Shepherd", DOB = new DateTime(2010, 12, 18), FavoriteFood = "Peanut butter"},
                new FavoritePet { Id = 3, Name = "Moss", Owner = "Shane", Breed = "Yorki", DOB = new DateTime(2004, 5, 26), FavoriteFood = "Biscuits"},
                new FavoritePet { Id = 4, Name = "Mischka", Owner = "Aleksei", Breed = "Cat", DOB = new DateTime(2022, 3, 7), FavoriteFood = "Butterflies"},
                new FavoritePet { Id = 5, Name = "Mock", Owner = "Vie", Breed = "Dog", DOB = new DateTime(2019, 8, 10), FavoriteFood = "Egg"}
            );
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoritePet> FavoritePet { get; set; }

    }
}