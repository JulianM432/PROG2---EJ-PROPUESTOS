using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioComposicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Juego juego;
        private void btnJugar_Click(object sender, EventArgs e)
        {
            FormConfig fConfig = new FormConfig();
            if (fConfig.ShowDialog() == DialogResult.OK)
            {
                juego = new Juego(fConfig.tbLocal.Text,fConfig.tbVisitante.Text);
                IniciarJuego();
            }
            fConfig.Dispose();
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            juego = new Juego();
            IniciarJuego();
        }
        private void IniciarJuego()
        {
            if(juego != null)
            {
                juego.Jugar();
                string[] resultados = juego.VerResultados();
                lbJuego.Items.Clear();
                foreach (string s in resultados)
                {
                    //MessageBox.Show(s);
                    lbJuego.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Me rompi.");
            }
        }
    }
}
