using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorReservacion
    {
        public void Agregar(int iCliente, int iHabitacion, TextBox Dia, List<Reservaciones> reservaciones)
        {
            reservaciones.Add(new Reservaciones(iCliente, iHabitacion, int.Parse(Dia.Text)));
        }
        public void MostrarReservaciones(Panel panel, List<Reservaciones> reservaciones, 
            List<Clientes> clientes, List<Habitacion> habitacion)
        {
            int x = 10, y = 10, contador = 0;
            for (int i = 0; i < reservaciones.Count; i++)
            {
                if (contador == 3)
                {
                    x = 0; y += 170;
                }
                Button b = new Button();
                var bc = clientes[reservaciones[i].ICliente].Nombre+" "+clientes[reservaciones[i]
                    .ICliente].Apellidos;
                var bh = habitacion[reservaciones[i].IHabitacion].Tipo+" "+habitacion[reservaciones[i].
                    IHabitacion].Costo + reservaciones[i].Dias.ToString();
                b.Text = bc+bh;
                b.Width = 150; b.Height = 150;
                b.Location = new System.Drawing.Point(x, y);
                panel.Controls.Add(b);
                x += 170;
                contador++;
            }
        }
    }
}