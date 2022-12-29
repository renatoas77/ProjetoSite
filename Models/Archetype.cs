namespace FighteR_PG.Models
{
    public class Archetype
    {
        public int ArchetypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Character> Characters { get; set; }
    }
}
