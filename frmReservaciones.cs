using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace Hotel
{
    public partial class frmReservaciones : Form
    {
        ManejadorCliente mc;
        manejadorHabitaciones mh;
        ManejadorReservacion mr;
        int filaCliente = 0, filaHabitacion = 0;
        List<Reservaciones> reservacion = new List<Reservaciones>();
        public frmReservaciones()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
            mh = new manejadorHabitaciones();
            mr = new ManejadorReservacion();
            
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaCliente = e.RowIndex;
        }

        private void dtgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaHabitacion = e.RowIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mr.Agregar(filaCliente, filaHabitacion, txtDias, reservacion);
            mr.MostrarReservaciones(pListas, reservacion, frmClientes.clientes, frmHabitaciones.habitacion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pListas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            mc.Mostrar(dtgvClientes, frmClientes.clientes);
            mh.Mostrar(dtgvHabitaciones, frmHabitaciones.habitacion);
        }
    }
}
