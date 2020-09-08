using System.Collections.Generic;

namespace MarketAPI.Models
{
    public class Anuncio
    {
        public Anuncio()
        {
            this.Imagens = new List<Imagem>();
        }
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string PreTitulo { get; set; }
        public string Titulo { get; set; }
        public ICollection<Imagem> Imagens { get; set; }
        public string Imagem { get; set; }
        public string Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Endereco DetalhesEndereco { get; set; }
        public bool Possui360 { get; set; }
        public bool EFavorita { get; set; }
        public short Avaliacao { get; set; }
        public string Descricao { get; set; }
        public int Capacidade { get; set; }
        public decimal Hora { get; set; }
        public decimal Diaria { get; set; }
        public string Codigo { get; set; }
        public bool EstaReservado { get; set; }
        public bool ESelecionado { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}