using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAgregacion
{
    internal class Jugador
    {
        public string Nombre { get; private set; }
        public int NroCamiseta { get; private set; }
        public int Dni { get; private set; }
        public Jugador(string nombre, int dni, int nroCamiseta)
        {
            Nombre = nombre;
            NroCamiseta = nroCamiseta;
            Dni = dni;
        }
        public override string ToString()
        {
            return string.Format("Nombre:{0,10}|DNI:{1,10}|Nro:{2,2}",Nombre,Dni,NroCamiseta);
        }
    }
}
