using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAgregacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
        }
        Equipo equipo;
        private void btnEquipo_Click(object sender, EventArgs e)
        {
            equipo = new Equipo(tbEquipo.Text);
            btnAgregar.Enabled = true;
            btnEquipo.Enabled = false;
            tbEquipo.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDNI.Text);
            int nro = Convert.ToInt32(tbNro.Text);
            if (!equipo.AgregarJugador(new Jugador(tbNombre.Text, dni, nro)))
            {
                MessageBox.Show("No se pudo agregar.");
            }
            tbNombre.Clear();
            tbDNI.Clear();
            tbNro.Clear();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] lista = equipo.VerLista();
            foreach(string txt in lista)
            {
                listBox1.Items.Add(txt);
            }
        }
    }
}
