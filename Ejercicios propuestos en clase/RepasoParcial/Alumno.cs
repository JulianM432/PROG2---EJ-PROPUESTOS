using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial
{
    internal class Alumno : Persona
    {
        public string Carrera { get; private set; }
        public int Legajo { get; private set; }
        public Tarjeta Tarjeta { get; private set; }
        public Alumno(string nombre,int dni,int legajo, string carrera) : base(nombre,dni)
        {
            Carrera = carrera;
            Legajo = legajo;
        }
        public void AgregarTarjeta(int codigo,double precio)
        {
            Tarjeta = new Tarjeta(codigo, precio);
        }
        public override string ToString()
        {
            return string.Format("Nombre:{0,30} | DNI:{1,10} | Legajo:{2,10} | Cursa {3,-40}",Nombre,Dni,Legajo,Carrera);
        }
    }
}
