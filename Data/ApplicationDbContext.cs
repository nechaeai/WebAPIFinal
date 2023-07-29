using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models; // Replace with your actual namespace
namespace WebAPIFinal.Data{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        TeamMembers = Set<TeamMember>();
    }

    public DbSet<TeamMember> TeamMembers { get; set; }
    // Add other DbSets for other tables here
}
}