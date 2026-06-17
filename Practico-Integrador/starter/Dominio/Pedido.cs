using System;

namespace starter.Dominio
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } // FK
        public DateTime Fecha { get; set; }
    }
}