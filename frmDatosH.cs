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

namespace Hotel
{
    public partial class frmDatosH : Form
    {
        manejadorHabitaciones mh;
        public frmDatosH()
        {
            InitializeComponent();
            mh = new manejadorHabitaciones();
            if (!frmHabitaciones.tipo.Equals(""))
            {
                cmbTipo.Text = frmHabitaciones.tipo;
                txtCosto.Text = frmHabitaciones.costo;
                txtServicios.Text = frmHabitaciones.servicios;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmHabitaciones.tipo.Equals(""))
            {
                //Para nuevo registro
                mh.Guardar(cmbTipo, txtCosto, txtServicios, frmHabitaciones.habitacion);
            }
            else
            {
                mh.BorrarEdit(frmHabitaciones.fila, frmHabitaciones.habitacion);
                mh.Guardar(cmbTipo, txtCosto, txtServicios, frmHabitaciones.habitacion);
            }
            Close();
        }
    }
}
