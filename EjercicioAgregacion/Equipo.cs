using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjercicioAgregacion
{
    internal class Equipo
    {
        public string Nombre { get; private set; }
        ArrayList jugadores = new ArrayList();
        public int CantJugadores { get; private set; } = 0;
        public Equipo(string nombre)
        {
            Nombre = nombre;
        }
        public bool AgregarJugador(Jugador jugador)
        {
            bool r = false;
            //bool hayEspacio = (CantJugadores >= 0 && CantJugadores < jugadores.Count);
            bool existeJugador = false;
            if (jugadores.Count > 0)
            {
                foreach (Jugador j in jugadores)
                {
                    existeJugador = j.Dni == jugador.Dni;
                    if (existeJugador) break;
                }
            }
            if (!existeJugador)
            {
                jugadores.Add(jugador);
                r = true;
            }
            return r;
        }
        public string[] VerLista()
        {
            int i = 0;
            string[] lista = new string[jugadores.Count];
            foreach (Jugador j in jugadores)
            {
                lista[i++] = j.ToString();
            }
            return lista;
        }
    }
}
