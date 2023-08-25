using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    internal class Sistema
    {
        ArrayList clientes = new ArrayList();
        public int CantClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        public void AgregarCliente(Cliente c)
        {
            clientes.Add(c);
        }
        public void RemoverCliente(int dni)
        {
            int pos = BuscarCliente(dni);
            if (pos != -1)
            {
                clientes.RemoveAt(pos);
            }
        }
        public int BuscarCliente(int dni)
        {
            int pos = -1;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente c = (Cliente)clientes[i];
                if (c.Dni == dni)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public Cliente VerCliente(int i)
        {
            bool seEncontro = i >= 0 && i < CantClientes;
            Cliente ret = null;
            if(seEncontro)
            {
                ret = (Cliente)clientes[i];
            }
            return ret;
        }
    }
}
