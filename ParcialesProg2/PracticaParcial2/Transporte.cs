using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    abstract class Transporte : IComparable
    {
        public double Precio { get; protected set; }
        public string Destino { get; protected set; }
        public Transporte(string destino ,double precio)
        {
            Destino = destino;
            Precio = precio;
        }
        public abstract double Costo();

        public int CompareTo(object obj)
        {
            return ((Transporte)obj).Destino.CompareTo(Destino);
        }
    }
}
