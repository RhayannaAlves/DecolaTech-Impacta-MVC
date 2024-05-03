using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendas.Models
{
    public class Login
    {
        public int LoginID { get; set; }

        [Display(Name = "E-mail")]
        public string LoginEmail { get; set; } = string.Empty;

        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        public string? Senha { get; set; }
        public int NivelAcesso { get; set; }


    }
}
