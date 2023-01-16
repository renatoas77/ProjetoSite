using FighteR_PG.Context;
using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly AppDbContext _context;

        public CharacterRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Character> Characters => _context.Characters
                                                    .Include(c => c.Sex)
                                                    .Include(c => c.Archetype);
    }
}
