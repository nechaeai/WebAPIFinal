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
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Nhi Nguyen", Birthdate = new DateTime(1999, 8, 17), CollegeProgram = "Information Technology", YearInProgram = "Senior"},
                new TeamMember { Id = 2, FullName = "Samir Agrawal", Birthdate = new DateTime(2002, 3, 22), CollegeProgram = "Information Technology", YearInProgram = "sophmore" },
                new TeamMember { Id = 3, FullName = "Aleksei Nechaev", Birthdate = new DateTime(2001, 1, 7), CollegeProgram = "Information Technology", YearInProgram = "junior" },
                new TeamMember { Id = 4, FullName = "Shane Irvine", Birthdate = new DateTime(2003, 9, 26), CollegeProgram = "Information Technology", YearInProgram = "Freshman" }
            );
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<FavoritePet> FavoritePet { get; set; }

    }
}