using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class Funcionario
    {   
        public int FuncionarioId { get; set; }

        [Display(Name = "Nome Completo")]
        [Required]
        public string FuncionarioName { get; set; }
        


    }
}
