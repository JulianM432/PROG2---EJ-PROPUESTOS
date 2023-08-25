using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioComposicion
{
    internal class Personaje
    {
        public string Nombre { get; private set; }
        public int Ataque { get; private set; }
        public int Defensa { get; private set; }
        public int Vida { get; private set; } = 200;
        public Personaje(string nombre, int ataque, int defensa)
        {
            Nombre = nombre;
            Ataque = ataque;
            Defensa = defensa;
        }
        public bool Enfrentamiento(int puntos)
        {
            Vida -= puntos;
            return Vida > 0;
        }
        public override string ToString()
        {
            return string.Format("{0,10}|{1,3} HP",Nombre,Vida);
        }
    }
}
