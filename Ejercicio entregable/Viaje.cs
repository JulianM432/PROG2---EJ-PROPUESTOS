using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    internal class Viaje
    {
        public string Fecha { get; private set; }
        public string Hora { get; private set; }
        public int CodigoLinea { get; private set; }
        public double Precio { get; private set; }
        public Viaje(string fecha, string hora, int codLinea, double precio)
        {
            Fecha = fecha;
            Hora = hora;
            Precio = precio;
            CodigoLinea = codLinea;
        }
    }
}
