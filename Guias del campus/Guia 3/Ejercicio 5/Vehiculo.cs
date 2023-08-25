using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Vehiculo
    {
        public string Traccion { get; private set; }
        public int CantRuedas { get; private set; }
        public int Pasajeros { get; private set; }
        public Vehiculo(string traccion, int cantRuedas, int pasajeros)
        {
            Traccion = traccion;
            CantRuedas = cantRuedas;
            Pasajeros = pasajeros;
        }

        public override string ToString()
        {
            return string.Format("Traccion:{0}|Ruedas:{1}|Pasajeros:{2}",Traccion,CantRuedas,Pasajeros);
        }
    }
}
