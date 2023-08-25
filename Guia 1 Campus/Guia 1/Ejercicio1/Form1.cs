using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Tipos de animal";
        }
        Animal[] animales = new Animal[20];
        int i = 0;
        int idx = -1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarEntradas())
            {
                double peso = Convert.ToDouble(tbPeso.Text);
                animales[i] = new Animal(tbNombre.Text, tbTipo.Text, peso);

                LimpiarEntradas();
                comboBox1.Items.Add(animales[i].Tipo);
                i++;
            }
            else
            {
                MessageBox.Show("Campos vacios.");
            }
        }
        #region Cosas_Innecesarias
        private bool VerificarEntradas()
        {
            return tbNombre.Text != "" && tbPeso.Text != "" && tbTipo.Text != "";
        }
        private void LimpiarEntradas()
        {
            tbNombre.Clear();
            tbTipo.Clear();
            tbEdad.Clear();
            tbPeso.Clear();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idx = comboBox1.SelectedIndex;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string tipo = comboBox1.SelectedItem.ToString();
            for (int j = 0; j < animales.Length; j++)
            {
                if (animales[j].Tipo == tipo)
                {
                    lbMostrar.Items.Add(animales[j].ToString());

                }
            }
        }
    }
}
