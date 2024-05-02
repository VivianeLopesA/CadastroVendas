using System.ComponentModel.DataAnnotations;

namespace CadastroVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string? ProdutoName { get; set; }

        [Required]
        public int? Quantidade { get; set; }

        [Display(Name = "Preço por unidade")]
        [Required]
        public decimal? PrecoUnidade { get; set; }

    }
}
