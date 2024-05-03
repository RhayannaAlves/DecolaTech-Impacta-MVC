using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Data Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtCad { get; set; }
        
        public string? Tipo { get; set; }
        
        [Required(ErrorMessage = "A quantidade do produto no estoque é obrigatório.")]
        [Display(Name = "Quantidade em Estoque")]
        public int QuantEstoque { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

    }
}
