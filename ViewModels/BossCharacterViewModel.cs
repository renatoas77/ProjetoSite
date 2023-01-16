using FighteR_PG.Models;
using FighteR_PG.Context;

namespace FighteR_PG.ViewModels
{
    public class BossCharacterViewModel
    {
        public IEnumerable<Boss> bosses { get; set; }
        public IEnumerable<Character> characters { get; set; }
    }
}
