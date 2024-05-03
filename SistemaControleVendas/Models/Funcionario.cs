using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Data Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtCad { get; set; }
        public string? CPF { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }              
        public string? Setor { get; set; }

        [Display(Name = "Nível Usuário")]
        public int NivelAcesso { get; set; }





    }
}
