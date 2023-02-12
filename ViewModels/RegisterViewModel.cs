using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using Newtonsoft.Json.Serialization;

namespace FighteR_PG.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password",ErrorMessage = "Senhas não são iguais")]
        [Display(Name = "Confirme a senha")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Page { get; set; }
    }
}
