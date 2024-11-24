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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitaciones hab = new frmHabitaciones();
            hab.MdiParent = this;
            hab.Show();
        }

        private void optClientes_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes();
            cli.MdiParent = this;
            cli.Show();
        }

        private void optReservacion_Click(object sender, EventArgs e)
        {
            frmReservaciones r = new frmReservaciones();
            r.MdiParent = this;
            r.Show();
        }
    }
}
