using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public Clientes(string nombre, string apellidos, string email, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Email = email;
            Telefono = telefono;
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

    }
}
