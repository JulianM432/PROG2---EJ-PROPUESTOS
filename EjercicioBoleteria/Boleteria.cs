using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBoleteria
{
    internal class Boleteria
    {
        private double recaudacion = 0;
        private ArrayList viajes = new ArrayList();
        public void AgregarMicro(Micro viaje)
        {
            viajes.Add(viaje);
            recaudacion += viaje.Precio;
            Cantidad++;
        }
        public Micro VerMicro(int i)
        {
            Micro ret = null;
            if(i < Cantidad && i >= 0)
            {
                ret = (Micro)viajes[i];
            }
            return ret;
        }
        public ArrayList ConsultarHorarios(string destino)
        {
            ArrayList aux = new ArrayList();
            for(int i = 0; i < viajes.Count; i++)
            {
                Micro unMicro = (Micro)viajes[i];
                if(unMicro.Destino == destino)
                {
                    aux.Add(unMicro);
                }
            }
            return aux;
        }
        public ListBox ConsultarPasaje(string destino, string hora)
        {
            ListBox aux = new ListBox();
            aux.Items.Clear();
            int pos = -1;
            ArrayList listMicros = ConsultarHorarios(destino);
            for( int i = 0;i < listMicros.Count; i++)
            {
                if ( ((Micro)listMicros[i]).HoraSalida == hora)
                {
                    pos = i;
                }
            }
            if (pos != -1)
            {
                bool[] listAsientos = ((Micro)listMicros[pos]).ConsultarAsiento();
                for (int i = 0; i < listAsientos.Length; i++)
                {
                    if (!listAsientos[i])
                    {
                        aux.Items.Add((i + 1).ToString());
                    }
                }
            }
            else
            {
                aux = null;
            }
            return aux;
        }
        public void VenderPasaje(Micro unMicro, int asiento)
        {
            int pos = viajes.IndexOf(unMicro);
            if(pos != -1)
            {
                ((Micro)viajes[pos]).ReservarAsiento(asiento);
            }
        }
        public int Cantidad { get; private set; } = 0;
    }
}
