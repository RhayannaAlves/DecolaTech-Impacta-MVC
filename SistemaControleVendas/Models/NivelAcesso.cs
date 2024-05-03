using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class NivelAcesso
    {
        public int NivelAcessoID { get; set; }

        [Display(Name = "Tipo Usuário")]
        public string? TipoUsuario { get; set; }

       


    }
}
