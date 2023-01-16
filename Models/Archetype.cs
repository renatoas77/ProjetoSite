using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Archetype
    {
        [Display(Name = "Arquetipo")]
        public int ArchetypeId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Arquetipo")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Descrição do arquetipo")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Description { get; set; }

        public List<Character> Characters { get; set; }
    }
}
