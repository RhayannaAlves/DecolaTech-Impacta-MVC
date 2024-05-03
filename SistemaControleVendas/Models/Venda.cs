using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class Venda
    {
        public int VendaID { get; set; }

        [Display(Name = "Data Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtCad { get; set; }
        public int FuncionarioID { get; set; }
        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }

        [Display(Name = "Valor total da Venda")]
        public decimal ValorTotal { get; set; }
    }
}
