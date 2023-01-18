using Microsoft.EntityFrameworkCore;
using FighteR_PG.Models;

namespace FighteR_PG.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet <Character> Characters { get; set; }
        public DbSet <Boss> Bosses { get; set; }
        public DbSet <Sex> Sexes { get; set; }
        public DbSet <Archetype> Archetypes { get; set; }
        public DbSet <Tier> Tier { get; set; }
        public DbSet <SelectedMembers> SelectedMembers { get; set; }
        public DbSet <Team> Team { get; set; }
        public DbSet <TeamMember> TeamMembers { get; set; }
    }
}
