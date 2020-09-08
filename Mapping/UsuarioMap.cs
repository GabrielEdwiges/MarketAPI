using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class UsuarioMap 
        : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuarios");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(40).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.Telefone).HasMaxLength(14).IsRequired();

            HasMany(x => x.Anuncios).WithRequired(x => x.Usuario);
            HasMany(x => x.Cartoes).WithRequired(x => x.Usuario);
        }
    }
}