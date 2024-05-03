using Microsoft.EntityFrameworkCore;
using SistemaControleVendas.Models;

namespace SistemaControleVendas.Data
{
    public class SistemaControleVendasContext : DbContext
    {
        public SistemaControleVendasContext (DbContextOptions<SistemaControleVendasContext> options)
            : base(options)
        {
        }

       
        public DbSet<SistemaControleVendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<SistemaControleVendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<SistemaControleVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SistemaControleVendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<SistemaControleVendas.Models.Login> Login { get; set; } = default!;
        public DbSet<SistemaControleVendas.Models.NivelAcesso> NivelAcesso { get; set; } = default!;
    }
}
