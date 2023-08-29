using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    internal class Profesor : Persona
    {
        public string Titulo { get; private set; }
        public int Legajo { get; private set; }
        public Profesor(string nombre, int dni, int legajo, string titulo) : base(nombre, dni)
        {
            Titulo = titulo;
            Legajo = legajo;
        }
        public override string ToString()
        {
            return string.Format("Nombre:{0,30} | DNI:{1,10} | Legajo:{2,10} | Titulo: {3,-40}", Nombre, Dni, Legajo, Titulo);
        }
    }
}
