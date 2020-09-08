namespace MarketAPI.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public int AnuncioId { get; set; }
        public Anuncio Anuncio { get; set; }
    }
}