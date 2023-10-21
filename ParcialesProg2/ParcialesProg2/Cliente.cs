using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ParcialesProg2
{
    internal class Cliente
    {
        public string Nombre{ get; private set; }
        public int NroCliente { get; private set; }
        protected ArrayList listaFacturas = new ArrayList();
        public Cliente(int nro, string nombre)
        {
            Nombre = nombre;
            NroCliente = nro;
        }
        public void RegistrarVenta(int nroFactura)
        {
            listaFacturas.Add(nroFactura);
        }
    }
}
