using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Malacate
    {
        public int CapacidadTiro { get; private set; }
        public string Control { get; private set; }
        public Malacate(int capacidadTiro, string control)
        {
            CapacidadTiro = capacidadTiro;
            Control = control;
        }
        public override string ToString()
        {
            return string.Format("Capacidad tiro:{0}|Control:{1}",CapacidadTiro,Control);
        }
    }
}
