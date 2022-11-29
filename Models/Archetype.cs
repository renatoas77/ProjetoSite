namespace FighteR_PG.Models
{
    public class Archetype
    {
        public int ArchetypeId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        public List<Character> Characters { get; set; }
    }
}
