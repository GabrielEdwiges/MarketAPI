using MarketAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace MarketAPI.Mapping
{
    public class DataSelecionadaMap : EntityTypeConfiguration<DataSelecionada>
    {
        public DataSelecionadaMap()
        {
            ToTable("Datas");
            HasKey(x => x.Id);

            Property(x => x.CalendarioId);
            Property(x => x.Data).IsRequired();
        }
    }
}