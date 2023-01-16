using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Sex
    {
        [Display(Name = "Sexo")]
        public int SexId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Sexo")]
        [MaxLength(1, ErrorMessage = "Maximo de {1} caracteres")]
        public Char SexCharacter { get; set; }
        public List<Character> Characters { get; set; }
        public List<Boss> Bosses { get; set; }
    }
}
