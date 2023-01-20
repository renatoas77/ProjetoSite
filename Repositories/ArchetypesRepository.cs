using FighteR_PG.Context;
using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;

namespace FighteR_PG.Repositories
{
    public class ArchetypesRepository : IArchetypesRepository
    {
        private readonly AppDbContext _context;

        public ArchetypesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Archetype> Archetypes => _context.Archetypes;
    }
}
