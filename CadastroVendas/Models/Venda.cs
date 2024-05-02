using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class Venda
    {
        public int VendaId { get; set; }

        [Display(Name = "Data e hora da venda")]
        [Required]
        public DateTime? DataHoraVenda { get; set;}

        [Required]
        public string? Produto { get; set; }

        [Required]
        public int Quantidade {  get; set; }

        [Display(Name = "Funcionário")]
        [Required]
        public string? Funcionario { get; set; }

        [Required]
        public string? Cliente { get; set; }

        [Display(Name = "Valor por Unidade")]
        [Required]
        public decimal? valorUnidade { get; set; }

    }
}
