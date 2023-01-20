using FighteR_PG.Models;

namespace FighteR_PG.ViewModels
{
    public class CharactersViewModel
    {
        public IEnumerable<Character> Characters { get; set; }
        public string Arquetipo { get; set; }
    }
}
