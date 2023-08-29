using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    internal class Persona
    {
        public string Nombre { get; private set; }
        public int Dni { get; private set; }
        public Persona(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }
    }
}
