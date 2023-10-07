using CadastroPedido.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroPedido.Infra.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Celular)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.Sexo)
                .HasColumnType("char")
                .IsRequired();
        }
    }
}
