using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_RepasoNo2
{
    internal class Alquiler
    {
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal KmRecorridos { get; set; }
        public decimal PrecioxKm { get; set; }
        public decimal Total { get; set; }

    }
}
