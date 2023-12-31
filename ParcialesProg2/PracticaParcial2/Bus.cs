﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    [Serializable]
    internal class Bus : Transporte
    {
        public string Patente { get; private set; }
        public string Estrellas { get; private set; }
        public Bus(string destino, double precio, string patente, string estrellas) : base(destino, precio)
        {
            Patente = patente;
            Estrellas = estrellas;
        }
        public override double Costo()
        {
            return Precio * 1.115 ;
        }
    }
}
