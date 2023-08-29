using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    internal class Tarjeta
    {
        public int Codigo { get; private set; }
        public double Saldo { get; private set; }
        public Tarjeta(int codigo, double saldo)
        {
            Codigo = codigo;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return string.Format("[TARJETA] Codigo:{0,5} | Saldo:{1,5}",Codigo,Saldo);
        }
    }
}
