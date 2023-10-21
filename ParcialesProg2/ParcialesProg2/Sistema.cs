using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ParcialesProg2
{
    internal class Sistema
    {
        private Empresa miEmpresa;
        public int FacturasCargadas { get; private set; }
        private ArrayList listaClientes = new ArrayList();
        public int CantClientes { get
            {
                return listaClientes.Count;
            } }
        public Cliente VerCliente(int i)
        {
            return (Cliente)listaClientes[i];
        }
        public Sistema(long cuit, string nombre)
        {
            miEmpresa = new Empresa(cuit, nombre);
            FacturasCargadas = 0;
        }
        public void AgregarCliente(Cliente nuevo)
        {
            listaClientes.Add(nuevo);
        }
        public Cliente BuscarCliente(int nroCliente)
        {
            Cliente unCliente = null;
            foreach (Cliente c in listaClientes)
            {
                if(c.NroCliente == nroCliente)
                {
                    unCliente = c;
                }
            }
            return unCliente;
        }
        public bool AgregarFactura(int nroCliente,int nroFactura, double monto)
        {
            Cliente unCliente = BuscarCliente(nroCliente);
            bool ret = false;
            if(unCliente != null)
            {
                if(unCliente is ClienteCuenta)
                {
                    ((ClienteCuenta)unCliente).AgregarFactura(nroFactura, monto);
                    FacturasCargadas++;
                    ret = true;
                }
            }
            return ret;
        }
        public bool AgregarPago(int nroCliente, double monto)
        {
            Cliente unCliente = BuscarCliente(nroCliente);
            bool ret = false;
            if(unCliente != null)
            {
                if(unCliente is ClienteCuenta)
                {
                    ((ClienteCuenta)unCliente).AgregarPago(monto);
                    ret = true;
                }
            }
            return ret;
        }
        public ClienteCuenta VerSaldo(int nroCliente)
        {
            Cliente unCliente = BuscarCliente(nroCliente);
            ClienteCuenta c = null;
            if(unCliente != null)
            {
                if(unCliente is ClienteCuenta)
                {
                    c = unCliente as ClienteCuenta;
                }
            }
            return c;
        }
    }
}
