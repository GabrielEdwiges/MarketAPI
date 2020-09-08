namespace MarketAPI.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}