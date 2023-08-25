using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregable
{
    internal class Cliente
    {
        public string Nombre { get; private set; }
        public int Dni { get; private set; }
        public string Direccion { get; private set; }
        public Tarjeta Tarjeta { get; private set; }
        public Cliente(string nombre, int dni, Tarjeta tarjeta)
        {
            Nombre = nombre;
            Dni = dni;
            Tarjeta = tarjeta;
            //Direccion = direccion;
        }
        //public void AgregarTarjeta(Tarjeta tarjeta)
        //{
        //    Tarjeta = tarjeta;
        //}
    }
}
