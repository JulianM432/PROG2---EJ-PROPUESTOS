using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialesProg2
{
    internal class ClienteCuenta : Cliente
    {
        private double saldo;
        public ClienteCuenta(int nroCliente, string nombre) : base(nroCliente, nombre)
        {
            saldo = 0;
        }
        public void AgregarFactura(int nroFactura, double monto)
        {
            saldo += monto;
            listaFacturas.Add(nroFactura);
        }
        public void AgregarPago(double valor)
        {
            saldo += valor;
        }
        public double VerSaldo()
        {
            return saldo;
        }
    }
}
