using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Avion : Transporte
    {
        public int Patente {  get; private set; }
        public Avion(string destino, double precio, int patente) : base(destino, precio)
        {
            Precio *= 1.30;
            Patente = patente;
        }
        public override double Costo()
        {
            return Precio * 1.21;
        }
    }
}
