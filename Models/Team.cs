using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Nome do time")]
        [MinLength(3, ErrorMessage = "Minimo de {1} caracteres")]
        public string Name { get; set; }

        public List<TeamMember> Members { get; set; }

        public string Id;
        public virtual User User { get; set; }
    }
}
