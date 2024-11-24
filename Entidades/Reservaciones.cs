using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reservaciones
    {
        public Reservaciones(int iCliente, int iHabitacion, int dias)
        {
            ICliente = iCliente;
            IHabitacion = iHabitacion;
            Dias = dias;
        }

        public int ICliente { get; set; }
        public int IHabitacion { get; set; }
        public int Dias { get; set; }
    }
}
