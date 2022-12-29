namespace FighteR_PG.Models
{
    public class Sex
    {
        public int SexId { get; set; }
        public Char SexCharacter { get; set; }
        public List<Character> Characters { get; set; }
        public List<Boss> Bosses { get; set; }
    }
}
