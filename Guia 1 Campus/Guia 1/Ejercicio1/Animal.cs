using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Animal
    {
        public string Nombre { get; private set; }
        public string Tipo { get; private set; }
        public int Edad { get; private set; }
        public double Peso { get; private set; }
        public Animal(string nombre, string tipo, double peso)
        {
            Nombre = nombre;
            Tipo = tipo;
            Peso = peso;
        }
        public void IndicarEdad(int edad)
        {
            Edad = edad;
        }
        public override string ToString()
        {
            return string.Format("Nombre:{0,20}|Tipo:{1,10}|Peso{2,5:f2}",Nombre,Tipo,Peso);
        }
    }
}
