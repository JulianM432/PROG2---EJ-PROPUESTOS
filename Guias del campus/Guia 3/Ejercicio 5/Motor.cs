using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Motor
    {
        public int Potencia { get; private set; }
        public string TipoCombustible { get; private set; }
        public int Cilindrada { get; private set; }
        public int NroSerie { get; private set; }
        public Motor(int potencia, string tipoCombustible, int cilindrada, int nroSerie)
        {
            Potencia = potencia;
            TipoCombustible = tipoCombustible;
            Cilindrada = cilindrada;
            NroSerie = nroSerie;
        }
        public override string ToString()
        {
            return string.Format("Potencia:{0}|Tipo combustible:{1}|Cilindrada:{2}|Nro Serie:{3}",Potencia,TipoCombustible,Cilindrada,NroSerie);
        }
    }
}
