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
        int cantViajes = 0;
        public Tarjeta(int codigo)
        {
            Codigo = codigo;
        }
        public void AgregarViaje(Viaje viaje)
        {
            if(cantViajes >= 0 && cantViajes < viajes.Length)
            {
                viajes[cantViajes++] = viaje;
            }
        }
        public void InvalidarTarjeta()
        {
            Valida = false;
        }
    }
}
