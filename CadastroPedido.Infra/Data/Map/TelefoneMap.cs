using CadastroPedido.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroPedido.Infra.Data.Map
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DDD)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
