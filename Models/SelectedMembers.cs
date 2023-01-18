using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class SelectedMembers
    {
        public int SelectedMembersId { get; set; }
        public Character Character { get; set; }

        [MaxLength(200)]
        public string SelectionId { get; set; }
    }
}
