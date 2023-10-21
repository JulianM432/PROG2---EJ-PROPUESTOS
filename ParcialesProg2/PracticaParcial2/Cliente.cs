using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Cliente
    {
        public string Nombre { get; private set; }
        public long Cuil { get; private set; }
        public int Telefono { get; private set; }
        public long TarjetaCredito { get; private set; }
        public Cliente(string nombre, long cuil, int telefono, long tarjetaCredito)
        {
                Nombre = nombre;
                Cuil = cuil;
                Telefono = telefono;
                TarjetaCredito = tarjetaCredito;
        }
    }
}
