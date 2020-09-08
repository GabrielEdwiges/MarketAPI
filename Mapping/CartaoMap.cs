using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class CartaoMap: EntityTypeConfiguration<Cartao>
    {
        public CartaoMap()
        {
            ToTable("Cartoes");
            HasKey(x => x.Id);
            Property(x => x.NumeroCartao).HasMaxLength(4).IsRequired();
            Property(x => x.Titular).HasMaxLength(40).IsRequired();
            Property(x => x.UsuarioId).IsRequired();
        }
    }
}