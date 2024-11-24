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
    public partial class frmDatosCliente : Form
    {
        ManejadorCliente mc;
        public frmDatosCliente()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
            if (!frmClientes.nombre.Equals(""))
            {
                txtNombre.Text = frmClientes.nombre;
                txtApellidos.Text = frmClientes.apellidos;
                txtEmail.Text = frmClientes.email;
                txtTelefono.Text = frmClientes.telefono;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmClientes.nombre.Equals(""))
            {
                //Para nuevo registro
                mc.Guardar(txtNombre, txtApellidos, txtEmail, txtTelefono, frmClientes.clientes);
            }
            else
            {
                mc.BorrarEdit(frmClientes.fila, frmClientes.clientes);
                mc.Guardar(txtNombre, txtApellidos, txtEmail, txtTelefono, frmClientes.clientes);
            }
            Close();
        }
    }
}
