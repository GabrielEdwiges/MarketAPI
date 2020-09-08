using System;

namespace MarketAPI.Models
{
    public class DataSelecionada
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public int CalendarioId { get; set; }
        public Calendario Calendario { get; set; }
    }
}