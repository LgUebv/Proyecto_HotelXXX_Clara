using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class frmHabitaciones : Form
    {
        manejadorHabitaciones mh;
        public static List<Habitacion> habitacion = new List<Habitacion>();
        public static string tipo, costo, servicios;
        public static int fila = 0, columna = 0;

        private void dtgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if(columna == 3)
            {
                mh.Borrar(fila, habitacion, dtgvHabitaciones.Rows[fila].Cells[0].Value.ToString());
                Actualizar();
            }
            if(columna == 4)
            {
                tipo = dtgvHabitaciones.Rows[fila].Cells[0].Value.ToString();
                costo = dtgvHabitaciones.Rows[fila].Cells[1].Value.ToString();
                servicios = dtgvHabitaciones.Rows[fila].Cells[2].Value.ToString();
                frmDatosH fd = new frmDatosH();
                fd.ShowDialog();
                Actualizar();
            }
        }

        private void txtHabitacion_TextChanged(object sender, EventArgs e)
        {
            mh.Buscar(dtgvHabitaciones, txtHabitacion.Text, habitacion);
        }

        public frmHabitaciones()
        {
            InitializeComponent();
            mh = new manejadorHabitaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tipo = ""; costo = ""; servicios = "";
            frmDatosH fd = new frmDatosH();
            fd.ShowDialog();
            Actualizar();
        }
        void Actualizar()
        {
            mh.Mostrar(dtgvHabitaciones, habitacion);
        }
    }
}
