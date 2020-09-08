using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class CalendarioMap : EntityTypeConfiguration<Calendario>
    {
        public CalendarioMap()
        {
            ToTable("Calendarios");
            HasKey(x => x.Id);
            Property(x => x.AnuncioId).IsRequired();
            HasMany(x => x.DatasSelecionadas).WithRequired(x => x.Calendario);
        }
    }
}