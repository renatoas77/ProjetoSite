using FighteR_PG.Models;

namespace FighteR_PG.Repositories.IRepositories
{
    public interface IArchetypesRepository
    {
        IEnumerable<Archetype> Archetypes { get; }
    }
}
