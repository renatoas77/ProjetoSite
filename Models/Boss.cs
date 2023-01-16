using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Boss
    {
        public int BossId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Nome")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Imagem")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Região")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Region { get; set; }


        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Imagem daRegião")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string RegionImage { get; set; }

        [Display(Name = "Geral")]
        public string GerneralText { get; set; }

        public int SexId { get; set; }

        [Display(Name = "Sexo")]
        public Sex Sex { get; set; }
        public int TierId { get; set; }
        public Tier Tier { get; set; }
    }
}
