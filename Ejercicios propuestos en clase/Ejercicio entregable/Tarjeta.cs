using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    internal class Tarjeta
    {
        public int Codigo { get; private set; }
        public bool Valida { get; private set; } = true;
        private Viaje[] viajes = new Viaje[10];
        public int CantViajes { get; private set; } = 0;
        public Tarjeta(int codigo)
        {
            Codigo = codigo;
        }
        public void AgregarViaje(Viaje viaje)
        {
            if(CantViajes >= 0 && CantViajes < viajes.Length)
            {
                viajes[CantViajes++] = viaje;
            }else
            {
                for(int i = 0; i < viajes.Length - 1; i++)
                {
                    viajes[i] = viajes[i+1];
                }
                viajes[viajes.Length - 1] = viaje;
            }
        }
        public void InvalidarTarjeta()
        {
            Valida = false;
        }
        public Viaje VerViaje(int i)
        {
            Viaje unViaje = null;
            if(i >= 0 && i < viajes.Length)
            {
                unViaje = viajes[i];
            }
            return unViaje;
        } 
    }
}
