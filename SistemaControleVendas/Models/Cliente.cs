using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Data Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtCad { get; set; }
        public string? CPF { get; set; }

        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Display(Name = "Nível Usuário")]
        public int NivelAcesso { get; set; }

    }
}
