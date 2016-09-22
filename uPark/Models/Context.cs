using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

    }
}