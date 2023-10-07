using CadastroPedido.Domain.Model;
using CadastroPedido.Infra.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace CadastroPedido.Infra.Data
{
    public class CadastroPedidoDBContext : DbContext
    {
        public CadastroPedidoDBContext(DbContextOptions<CadastroPedidoDBContext> options) : base(options) 
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
