using Microsoft.EntityFrameworkCore;
using WebAPIFinal.Models;
namespace WebAPIFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            SpongeBobCharacter = Set<SpongeBobCharacter>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpongeBobCharacter>().HasData(
        new SpongeBobCharacter { Id = 1, Name = "Goofy Goober", Role = "Mascot", FirstAppearance = new DateTime(2004, 11, 19), VoicedBy = "Tim Blaney" },
        new SpongeBobCharacter { Id = 3, Name = "Patrick Star", Role = "SpongeBob's best friend", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Bill Fagerbakke" },
        new SpongeBobCharacter { Id = 4, Name = "Squidward Tentacles", Role = "SpongeBob's neighbor and coworker", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Rodger Bumpass" },
        new SpongeBobCharacter { Id = 5, Name = "Mr. Krabs", Role = "Owner of the Krusty Krab", FirstAppearance = new DateTime(1999, 5, 1), VoicedBy = "Clancy Brown" }
);
        }
        public DbSet<SpongeBobCharacter> SpongeBobCharacter { get; set; }

    }
}