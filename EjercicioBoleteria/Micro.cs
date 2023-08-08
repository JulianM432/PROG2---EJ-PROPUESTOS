using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBoleteria
{
    internal class Micro
    {
        private string destino;
        private int cantAsientos;
        private string horario;
        private double precio;
        private bool[] asientos;
        private int id;
        public string Fecha { get; set; }
        public string Destino { get; }
        public string HoraSalida
        {
            get
            {
                return horario;
            }
        }
        public double Precio { get; }
        public Micro(string destino, int asientos, double precio, string horario, int codigo)
        {
            this.destino = destino;
            cantAsientos = asientos;
            this.precio = precio;
            this.horario = horario;
            id = codigo;
        }
        public bool[] ConsultarAsiento()
        {
            return asientos;
        }
        public bool ReservarAsiento(int asiento)
        {
            bool ret = false;
            if (asiento >= 0 && asiento < asientos.Length && asientos[asiento] == false)
            {
                this.asientos[asiento] = true;
                ret = true;
            }
            return ret;
        }
    }
}
