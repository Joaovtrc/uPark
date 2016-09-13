using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Usuario
    {

        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public int CPF { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Carro Carro { get; set; }
        public Reserva ReservaUsuario { get; set; }

    }
}