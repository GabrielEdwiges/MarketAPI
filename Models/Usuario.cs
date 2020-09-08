using System.Collections.Generic;

namespace MarketAPI.Models
{
    public class Usuario
    {
        public Usuario()
        {
            this.Anuncios = new List<Anuncio>();
            this.Cartoes = new List<Cartao>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefone { get; set; }
        public Imagem FotoPerfil { get; set; }
        public ICollection<Calendario> Calendarios { get; set; }
        public int CartaoId { get; set; }
        public ICollection<Cartao> Cartoes { get; set; }
        public bool EAdministrador { get; set; }
        public ICollection<Anuncio> Anuncios { get; set; }
    }
}