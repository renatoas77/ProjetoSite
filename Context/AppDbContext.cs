using Microsoft.EntityFrameworkCore;
using FighteR_PG.Models;

namespace FighteR_PG.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        DbSet <Character> Characters { get; set; }
        DbSet <Boss> Bosses { get; set; }
        DbSet <Sex> Sexes { get; set; }
        DbSet <Archetype> Archetypes { get; set; }

    }
}
