using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class ImagemMap : EntityTypeConfiguration<Imagem>
    {
        public ImagemMap()
        {
            ToTable("Imagens");
            HasKey(x => x.Id);

            Property(x => x.Source).IsRequired();
            Property(x => x.AnuncioId).IsRequired();
        }
    }
}