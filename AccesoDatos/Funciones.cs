using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionChacarron;

namespace AccesoDatos
{
    public class Funciones
    {
        Base b = new Base("localhost", "root", "", "Hotel");

        public string Guardar(string q)
        {
            return b.comandos(q);
        }

        public DataSet Mostrar(string q, string tabla)
        {
            return b.Mostrar(q, tabla);
        }

        public string Borrar(string q)
        {
            return b.comandos(q);
        }

        public string Modificar(string q)
        {
            return b.comandos(q);
        }
        public string ObtenerDato(string q, string tabla, string campo)
        {
            return b.ObtenerDatos(q, tabla, campo);
        }
    }
}
