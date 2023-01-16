using FighteR_PG.Models;

namespace FighteR_PG.Repositories.IRepositories
{
    public interface IBossRepository
    {
        IEnumerable<Boss> Bosses { get; }
    }
}
