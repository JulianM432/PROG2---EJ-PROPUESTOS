using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    internal class Contenedor
    {
        List<string[]> fuente = new List<string[]>();
        public List<string[]> Listar()
        {
            fuente.Clear();
            fuente.Add(new string[] { "21.000.000", "Cruz, Juan" });
            fuente.Add(new string[] { "22.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "23.010.000", "Mitre, Bartolomé" });
            fuente.Add(new string[] { "24.020.000", "Urquiza, Justo José" });
            fuente.Add(new string[] { "21.030.000", "Rosas, Juan Manuel" });
            fuente.Add(new string[] { "40.000", "Sarmiento, Faustino" });
            fuente.Add(new string[] { "13.300.000", "Milman, José" });
            fuente.Add(new string[] { "21.000.000", "Montes, Andrés" });
            fuente.Add(new string[] { "21.000.000", "Gutierrez, José María" });
            fuente.Add(new string[] { "20.140.000", "Gomez, María Laura" });
            fuente.Add(new string[] { "31.000.000", "Steiner, Lucrecia" });
            fuente.Add(new string[] { "1.000.000", "de la Vega, Alejandro" });
            fuente.Add(new string[] { "21.000.000", "Sanchez García, Demetrio" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "3.000.000", "Fourier, Joshep" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "21.000.000", "Cruz, Juan" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            fuente.Add(new string[] { "21.000.000", "López y Planes, Vicente" });
            return fuente;
        }

    }
}
