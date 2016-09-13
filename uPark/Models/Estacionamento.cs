using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace uPark.Models
{
    public class Estacionamento
    {
        public int EstacionamentoId { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public int NumeroVagas { get; set; }
        public string CNPJ { get; set; }
        public double Preço { get; set; }
        public DateTime HorarioFuncio { get; set; }
        public int VagasDisponiveis { get; set; }

    }
}