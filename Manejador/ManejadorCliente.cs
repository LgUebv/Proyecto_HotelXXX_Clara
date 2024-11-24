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
    public class ManejadorCliente
    {
        public void Guardar(TextBox nombre, TextBox apellidos, TextBox email,
            TextBox telefono, List<Clientes> cliente)
        {
            cliente.Add(new Clientes(nombre.Text, apellidos.Text, email.Text, telefono.Text));
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
        public void Mostrar(DataGridView tabla, List<Clientes> cliente)
        {
            tabla.Columns.Clear();
            tabla.DataSource = cliente.ToList();
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));
            tabla.Columns.Insert(5, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        public void Borrar(int i, List<Clientes> cliente, string dato)
        {
            DialogResult rs = MessageBox.Show(
                $"Estás seguro de borrar {dato}", "!ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                cliente.RemoveAt(i);
            }
        }
        public void BorrarEdit(int i, List<Clientes> cliente)
        {
            cliente.RemoveAt(i);
        }
        public void Buscar(DataGridView tabla, string texto, List<Clientes> cliente)
        {
            tabla.Columns.Clear();
            var rs = cliente.FindAll(x => x.Nombre.Contains(texto));
            tabla.Columns.Clear();
            tabla.DataSource = cliente.ToList();
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Red));
            tabla.Columns.Insert(5, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
