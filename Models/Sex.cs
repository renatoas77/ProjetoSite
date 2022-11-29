namespace FighteR_PG.Models
{
    public class Sex
    {
        int SexId { get; set; }
        Char SexCharacter { get; set; }
        public List<Character> Characters { get; set; }
    }
}
