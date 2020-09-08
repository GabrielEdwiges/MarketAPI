using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class EnderecoMap
        : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Enderecos");
            HasKey(x => x.Id);
            Property(x => x.Cep).HasMaxLength(8).IsRequired();
            Property(x => x.Latitude).IsRequired();
            Property(x => x.Longitude).IsRequired();
            Property(x => x.NomeDoEdificio).HasMaxLength(30).IsRequired();
        }
    }
}