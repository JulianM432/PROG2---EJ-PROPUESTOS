using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Camioneta : Vehiculo
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Patente { get; private set; }
        public int AñoFabricacion { get; private set; }
        public int CapacidadCarga { get; private set; }
        public Motor Motores { get; private set; }
        public Malacate Malacates { get; private set; }
        public Camioneta(string traccion,int cantRuedas, int cantPasajeros,string marca, string modelo, string patente,int aFabricacion,int capacidadCarga, Motor motor) : base(traccion, cantRuedas, cantPasajeros)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            AñoFabricacion = aFabricacion;
            CapacidadCarga = capacidadCarga;
            Motores = motor;
        }
        public void AgregarMalacate(Malacate malacate)
        {
            Malacates = malacate;
        }
        public override string ToString()
        {
            return string.Format("Marca:{0}|Modelo:{1}|Patente:{2}|Fabricado:{3}|Capacidad:{4}|Motor {5}",Marca,Modelo,Patente,AñoFabricacion,CapacidadCarga,Motores.ToString());
        }
    }
}
