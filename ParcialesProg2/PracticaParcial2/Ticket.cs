using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Ticket
    {
        public double PrecioFinal {  get; private set; }
        public Transporte Transporte { get; private set; }
        public DateTime fecha { get; private set; }
        public Ticket(Transporte transporte, Cliente unCliente)
        {
            Transporte = transporte;
            fecha = DateTime.Now;
            PrecioFinal = Transporte.Costo();
        }
        public string[] Imprimir()
        {
            string tipo = "Avion";
            if(Transporte is Bus)
            {
                tipo = "Bus";
            }
            return new string[] { "------------------------------","Fecha: " + fecha.ToShortDateString(), "Destino: " + Transporte.Destino, "Transporte: " + tipo, "Precio: " + PrecioFinal.ToString("0,00"), "------------------------------" };
        }
    }
}
