using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Collections;

namespace EjercicioComposicion
{
    internal class Juego
    {
        private Personaje local, visitante;
        static Random n = new Random();
        ArrayList resultado = new ArrayList();
        public Personaje Ganador { get; private set; }
        public Personaje Local { get { return local; } }
        public Personaje Visitante { get { return visitante; } }
        public Juego(string local, string visitante)
        {
            int atqL = n.Next(10, 60),
                atqV = n.Next(10, 60),
                defL = n.Next(10, 75),
                defV = n.Next(10, 75);
            this.local = new Personaje(local, atqL, defL);
            this.visitante = new Personaje(visitante, atqV, defV);
        }
        public Juego() : this("John Wick", "Kratos")
        {

        }
        public void Jugar()
        {
            int puntosL = Math.Abs(local.Defensa - visitante.Ataque) ;
            int puntosV = Math.Abs(local.Ataque - visitante.Defensa) ;
            bool localVivo;
            bool visitanteVivo;
            string text1, text2;
            resultado.Add(string.Format("{0,10}| A:{1} | D:{2} || {3,-10}| A:{4} | D:{5}", local.Nombre,local.Ataque,local.Defensa, visitante.Nombre, visitante.Ataque, visitante.Defensa) );
            resultado.Add(string.Format("") );
            do
            {
                int rngInjusto = n.Next(15);
                localVivo = local.Enfrentamiento(puntosL + rngInjusto);
                text1 = local.ToString();
                visitanteVivo = visitante.Enfrentamiento(puntosV + rngInjusto);
                text2 = visitante.ToString();
                resultado.Add(text1 + " // " + text2);
            } while (localVivo && visitanteVivo);
            if (localVivo)
            {
                Ganador = local;
                resultado.Add(local.Nombre + " es el ganador!");
            }
            else
            {
                Ganador = visitante;
                resultado.Add(visitante.Nombre + " es el ganador!");
            }
        }
        public string[] VerResultados()
        {
            int i = 0;
            string [] r = new string[resultado.Count];
            foreach (string s in resultado)
            {
                r[i++] = s;
            }
            return r;
        }
    }
}
