using FighteR_PG.Models;

namespace FighteR_PG.Repositories.IRepositories
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> Characters { get; }

    }
}
