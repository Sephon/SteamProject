using Microsoft.EntityFrameworkCore;
using SteamProject.Models;

namespace SteamProject.Database
{
    public class SteamDbContext : DbContext
    {
        public SteamDbContext(DbContextOptions<SteamDbContext> options) : base(options)
        {
        }

        // Define DBSets for your tables
        public DbSet<SteamApp> Reviews { get; set; }
    }
}
