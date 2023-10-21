using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ParcialesProg2
{
    internal class Empresa
    {
        public long Cuit { get; private set; }
        public string Nombre { get; private set; }
        public Empresa(long cuit, string nombre)
        {
            Cuit = cuit;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return string.Format("CUIT: {0} | NOMBRE: {1}",Cuit,Nombre); 
        }
    }
}
