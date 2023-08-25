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

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList vehiculos = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            if(form.ShowDialog() == DialogResult.OK)
            {
                int ruedas = Convert.ToInt32(form.tbCantRuedas.Text);
                int cantPasajeros = Convert.ToInt32(form.tbCantPasajeros.Text);
                int aFab = Convert.ToInt32(form.tbFabricacion.Text);
                int capCarga = Convert.ToInt32(form.tbCapacidad.Text);
                int potencia = Convert.ToInt32(form.tbPotencia.Text);
                int cilindrada = Convert.ToInt32(form.tbCilindrada.Text);
                int nroserie = Convert.ToInt32(form.tbNroSerie.Text);
                Motor unMotor = new Motor(potencia, form.tbTipoCombustible.Text, cilindrada, nroserie);
                Camioneta unaCamioneta = new Camioneta(form.tbTraccion.Text, ruedas, cantPasajeros, form.tbMarca.Text, form.tbModelo.Text, form.tbPatente.Text, aFab, capCarga, unMotor);
                if(!string.IsNullOrEmpty(form.tbCapacidadTiro.Text) && !string.IsNullOrEmpty(form.tbControl.Text))
                {
                    unaCamioneta.AgregarMalacate(new Malacate(Convert.ToInt32(form.tbCapacidadTiro.Text),form.tbControl.Text));
                }
                vehiculos.Add(unaCamioneta);
            }
            form.Dispose();
            listBox1.Items.Add(vehiculos[vehiculos.Count - 1]);
        }
    }
}
