using Microsoft.EntityFrameworkCore;
using MyWebApi.Models; // Replace with your actual namespace

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        TeamMembers = Set<TeamMember>();
    }

    public DbSet<TeamMember> TeamMembers { get; set; }
    // Add other DbSets for other tables here
}
