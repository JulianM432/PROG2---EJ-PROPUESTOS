using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    internal class Huesped
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Dni { get; private set; }
        public string FechaNac { get; private set; }
        public Huesped(string nombre, string apellido, int dni, string fecha)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNac = fecha;
        }
    }
}
