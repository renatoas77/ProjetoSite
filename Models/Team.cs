namespace FighteR_PG.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }

        public List<TeamMember> Members { get; set; }
    }
}
