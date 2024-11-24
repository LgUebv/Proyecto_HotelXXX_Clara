using Entidades;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmClientes : Form
    {
        ManejadorCliente mc;
        public static List<Clientes> clientes = new List<Clientes>();
        public static string nombre, apellidos, email, telefono;
        public static int fila = 0, columna = 0;

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            mc.Buscar(dtgvClientes, txtCliente.Text, clientes);
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            if (columna == 4)
            {
                mc.Borrar(fila, clientes, dtgvClientes.Rows[fila].Cells[0].Value.ToString());
                Actualizar();
            }
            if (columna == 5)
            {
                nombre = dtgvClientes.Rows[fila].Cells[0].Value.ToString();
                apellidos = dtgvClientes.Rows[fila].Cells[1].Value.ToString();
                email = dtgvClientes.Rows[fila].Cells[2].Value.ToString();
                telefono = dtgvClientes.Rows[fila].Cells[3].Value.ToString();
                frmDatosCliente fdc = new frmDatosCliente();
                fdc.ShowDialog();
                Actualizar();
            }
        }

        public frmClientes()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombre = ""; apellidos = ""; email = ""; telefono = "";
            frmDatosCliente fdc = new frmDatosCliente();
            fdc.ShowDialog();
            Actualizar();
        }
        void Actualizar()
        {
            mc.Mostrar(dtgvClientes, clientes);
        }
    }
}
