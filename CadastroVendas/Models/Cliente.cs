using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Display(Name = "Nome Completo")]
        [Required]
        public string? ClienteName { get; set; }

        [Required]
        public string? Rua { get; set; }

        [Display(Name = "Número")]
        [Required]
        public string? Numero { get; set; }

        [Required]
        public string? Bairro { get; set; }

        
        public string? Cidade { get; set; }

        public string Complemento { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Preencher seu UF")]
        public string? UF { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Preencher seu CEP")]
        public string? CEP { get; set; }

    }
}
