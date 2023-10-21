using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial2
{
    public partial class Form1 : Form
    {
        Sistema miSistema = new Sistema();
        //double precioBase = 1000;
        public Form1()
        {
            InitializeComponent();
            string[] destinos = { "Brasil", "Mar del Plata", "Cordoba" };
            string[] tipo = { "Avion", "Bus" };
            comboBoxDestino.Items.AddRange(destinos);
            comboBoxTransporte.Items.AddRange(tipo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbCuil.Text) || string.IsNullOrEmpty(tbNro.Text))
                {
                    throw new Exception("Campos vacios");
                }
                if (tbCuil.Text.Length != 11)
                {
                    throw new Exception("El cuil debe tener 11 digitos");
                }
                if (tbNro.Text.Length != 16)
                {
                    throw new Exception("El numero de tarjeta debe tener 16 digitos");
                }
                Cliente unCliente = new Cliente(tbNombre.Text, Convert.ToInt64(tbCuil.Text), Convert.ToInt32(tbTelefono.Text), Convert.ToInt64(tbNro.Text));
                double precioBase = Convert.ToDouble(tbPrecio.Text);
                if (comboBoxTransporte.SelectedText == "Bus")
                {
                    Bus unBus = new Bus(comboBoxDestino.SelectedText, precioBase, "ABC", 3);
                    miSistema.AgregarTransporte(unBus);
                    miSistema.AgregarTicket(new Ticket(unBus, unCliente));
                }
                else
                {
                    Avion unAvion = new Avion(comboBoxDestino.SelectedText, precioBase, 213);
                    miSistema.AgregarTransporte(unAvion);
                    miSistema.AgregarTicket(new Ticket(unAvion, unCliente));
                }
                tbCuil.Clear();
                tbTelefono.Clear();
                tbNro.Clear();
                tbNombre.Clear();
                MessageBox.Show(miSistema.VerTransporte(0).Destino);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarTickets vMostrar = new MostrarTickets();
            for (int i = 0; i < miSistema.CantTickets; i++)
            {
                vMostrar.listBox1.Items.AddRange(miSistema.VerTicket(i).Imprimir());
            }
            vMostrar.ShowDialog();
            vMostrar.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
