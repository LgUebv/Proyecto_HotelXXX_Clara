using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Manejador
{
    public class manejadorHabitaciones
    {
        public void Guardar(ComboBox Tipo, TextBox Costo, TextBox Servicios, List<Habitacion> habitacion)
        {
            habitacion.Add(new Habitacion(Tipo.Text, double.Parse(Costo.Text),Servicios.Text));
        }
        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Flat;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }
        public void Mostrar(DataGridView tabla, List<Habitacion> habitacion) 
        {
            tabla.Columns.Clear();
            tabla.DataSource = habitacion.ToList();
            tabla.Columns.Insert(3, Boton("Eliminar", Color.Red));
            tabla.Columns.Insert(4, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public void Borrar(int i, List<Habitacion> habitacion, string dato)
        {
            DialogResult rs = MessageBox.Show(
                $"Estás seguro de borrar {dato}", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                habitacion.RemoveAt(i);
            }
        }
        public void BorrarEdit(int i, List<Habitacion> habitacion)
        {
            habitacion.RemoveAt(i);
        }
        public void Buscar(DataGridView tabla, string texto, List<Habitacion> habitacion)
        {
            tabla.Columns.Clear();
            var rs = habitacion.FindAll(x=>x.Tipo.Contains(texto));
            tabla.Columns.Clear();
            tabla.DataSource = habitacion.ToList();
            tabla.Columns.Insert(3, Boton("Eliminar", Color.Red));
            tabla.Columns.Insert(4, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
