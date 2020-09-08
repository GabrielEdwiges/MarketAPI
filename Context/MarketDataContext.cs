using MarketAPI.Mapping;
using MarketAPI.Models;
using System.Data.Entity;

namespace MarketAPI.Context
{
    public class MarketDataContext : DbContext
    {
        public MarketDataContext()
            :base("MarketConnectionString")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<DataSelecionada> DataSelecionadas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnuncioMap());
            modelBuilder.Configurations.Add(new CalendarioMap());
            modelBuilder.Configurations.Add(new CartaoMap());
            modelBuilder.Configurations.Add(new DataSelecionadaMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new ImagemMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}