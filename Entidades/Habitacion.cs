using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion(string tipo, double costo, string servicios)
        {
            Tipo = tipo;
            Costo = costo;
            Servicios = servicios;
        }

        public string Tipo { get; set; }
        public double Costo { get; set; }
        public string Servicios { get; set; }
    }
}
