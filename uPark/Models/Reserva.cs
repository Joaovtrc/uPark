using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime HorarioEntrara { get; set; }
        public DateTime HorarioSaida { get; set; }

    }
}