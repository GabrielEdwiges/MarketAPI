using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class AnuncioMap : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioMap()
        {
            ToTable("Anuncios");
            HasKey(x => x.Id);
            Property(x => x.Titulo).HasMaxLength(30).IsRequired();
            Property(x => x.PreTitulo).HasMaxLength(15).IsOptional();
            Property(x => x.Hora).IsRequired();
            Property(x => x.Diaria).IsRequired();
            Property(x => x.Capacidade).IsRequired();
            Property(x => x.Descricao).HasMaxLength(500).IsOptional();
            Property(x => x.Codigo).IsRequired();
            Property(x => x.Categoria).HasMaxLength(10).IsRequired();
            Property(x => x.EFavorita).IsRequired();
            Property(x => x.Endereco).IsRequired();
            Property(x => x.Possui360).IsRequired();
            Property(x => x.UsuarioId).IsRequired();
            Property(x => x.EnderecoId).IsRequired();

            HasMany(x => x.Imagens).WithRequired(x => x.Anuncio);
        }
    }
}