using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    [Serializable]
    internal class Avion : Transporte
    {
        public string Patente {  get; private set; }
        public Avion(string destino, double precio, string patente) : base(destino, precio)
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
