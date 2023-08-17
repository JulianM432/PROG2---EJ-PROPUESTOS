using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioEntregable
{
    public partial class Form1 : Form
    {
        Sistema sistema = new Sistema();
        int i = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd fAdd = new FormAdd();
            if(fAdd.ShowDialog() == DialogResult.OK)
            {
                string nombre = fAdd.tbNombre.Text;
                int dni = Convert.ToInt32(fAdd.tbDNI.Text);
                int codigo = Convert.ToInt32(fAdd.tbNumTarjeta.Text);
                Tarjeta tarjeta = new Tarjeta(codigo);
                Cliente unCliente = new Cliente(nombre, dni, tarjeta);
                sistema.AgregarCliente(unCliente);
                labCantClientes.Text = sistema.CantClientes.ToString();
            }
            fAdd.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(tbDoc.Text);
            if(i != -1)
            {
                sistema.RemoverCliente(dni);
                lbClientes.Items.RemoveAt(i);
            }
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {

        }

        private void btnViaje_Click(object sender, EventArgs e)
        {

        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lbClientes.SelectedIndex;
        }
    }
}
