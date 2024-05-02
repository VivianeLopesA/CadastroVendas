using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class ADM
    {
        public int ADMId { get; set; }

        [Display(Name = "Nome")]
        public string? ADMName { get; set; }
    }
}
