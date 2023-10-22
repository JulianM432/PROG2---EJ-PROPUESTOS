using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    [Serializable]
    internal class Cliente
    {
        public string Nombre { get; private set; }
        public string Cuil { get; private set; }
        public int Telefono { get; private set; }
        public string TarjetaCredito { get; private set; }
        public Cliente(string nombre, string cuil, int telefono, string tarjetaCredito)
        {
            if (cuil.Length != 11)
            {
                throw new Exception("El cuil debe tener 11 digitos");
            }
            if (tarjetaCredito.Length != 16)
            {
                throw new Exception("El numero de tarjeta debe tener 16 digitos.");
            }
            if(string.IsNullOrEmpty(cuil) || string.IsNullOrEmpty(tarjetaCredito))
            {
                throw new Exception("Campos vacios.");
            }
            Nombre = nombre;
            Cuil = cuil;
            Telefono = telefono;
            TarjetaCredito = tarjetaCredito;
        }
    }
}
