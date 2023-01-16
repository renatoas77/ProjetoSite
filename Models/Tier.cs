using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Tier
    {
        public int TierId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Tier")]
        [MaxLength(10, ErrorMessage = "Maximo de {1} caracteres")]
        public string Name { get; set; }
        public List<Boss> Bosss { get; set; }
    }
}
