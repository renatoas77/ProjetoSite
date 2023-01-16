using FighteR_PG.Context;
using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Repositories
{
    public class BossRepository : IBossRepository
    {
        private readonly AppDbContext _context;

        public BossRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Boss> Bosses => _context.Bosses
                                          .Include(b => b.Sex)
                                          .Include(b => b.Tier);
    }
}
