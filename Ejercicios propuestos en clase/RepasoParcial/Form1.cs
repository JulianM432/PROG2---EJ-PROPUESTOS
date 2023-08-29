using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace RepasoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList lista = new ArrayList();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lista.Add(new Alumno("Julian Misere",43292848,17459,"Programacion"));
            lista.Add(new Profesor("Jorge Jorginho", 12312323, 12312, "Ingeniero Informatico"));
            lista.Add(new Alumno("Marco Polo", 34343434, 12121, "Arquitectura"));
            lista.Add(new Profesor("Fabri Fabinho", 89898989, 434343, "Ingeniero Civil"));
            Alumno unAlumno = new Alumno("Fernando Fernandez", 67676676, 76890, "Medicina");
            unAlumno.AgregarTarjeta(123, 10000);
            lista.Add(unAlumno);
            foreach (Persona p in lista)
            {
                lbMostrar.Items.Add(p.ToString() );
                if(p is Alumno)
                {
                    Alumno a = p as Alumno;
                    if(a.Tarjeta != null)
                    {
                        lbMostrar.Items.Add(a.Tarjeta.ToString() );
                    }
                }
            }

        }
    }
}
