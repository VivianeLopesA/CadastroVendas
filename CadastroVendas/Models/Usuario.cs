using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string? ADMName { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        public string? email {  get; set; }

        [Display(Name = "Senha")]
        [Required]
        [StringLength(8, MinimumLength = 6, ErrorMessage = "Senha deve ter entre 4 e 8 caracteres")]
        public string? senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Compare("senha", ErrorMessage = "Senhas informadas não conferem")]
        public string? ConfirmarSenha { get; set; }


        [Display(Name = "Nível de acesso")]
        [Required]
        [Range(1 , 3 , ErrorMessage = "Os níveis de acesso disponíveis são: 1 - ADM , 2 - Funcionário , 3 - Cliente")]
        public int nivelAcesso { get; set; }    
    }
}
