using System.Collections.Generic;

namespace MarketAPI.Models
{
    public class Calendario
    {
        public Calendario()
        {
            this.DatasSelecionadas = new List<DataSelecionada>();
        }
        public int Id { get; set; }
        public int AnuncioId { get; set; }
        public Anuncio Anuncio { get; set; }
        public ICollection<DataSelecionada> DatasSelecionadas { get; set; }
    }
}