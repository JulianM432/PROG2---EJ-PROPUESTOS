using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            btnViaje.Enabled = false;
            btnRemove.Enabled = false;
            btnVerViaje.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd fAdd = new FormAdd();
            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                string nombre = fAdd.tbNombre.Text;
                int dni = Convert.ToInt32(fAdd.tbDNI.Text);
                int codigo = Convert.ToInt32(fAdd.tbNumTarjeta.Text);
                Tarjeta tarjeta = new Tarjeta(codigo);
                Cliente unCliente = new Cliente(nombre, dni, tarjeta);
                sistema.AgregarCliente(unCliente);
                labCantClientes.Text = sistema.CantClientes.ToString();
                ActualizarLista();
            }
            fAdd.Dispose();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Cliente borrarCliente = sistema.VerCliente(i);
            sistema.RemoverCliente(borrarCliente.Dni);
            lbClientes.Items.RemoveAt(i);
            //ActualizarLista();
        }
        private void btnViaje_Click(object sender, EventArgs e)
        {
            FormViaje formViaje = new FormViaje();
            if (formViaje.ShowDialog() == DialogResult.OK)
            {
                string fecha = formViaje.tbFecha.Text;
                string hora = formViaje.tbHora.Text;
                double precio = Convert.ToDouble(formViaje.tbPrecio.Text);
                int codigo = Convert.ToInt32(formViaje.tbCodigo.Text);
                Viaje unViaje = new Viaje(fecha, hora, codigo, precio);
                Cliente unCliente = sistema.VerCliente(i);
                unCliente.Tarjeta.AgregarViaje(unViaje);
            }
            formViaje.Dispose();
            ActualizarLista();
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lbClientes.SelectedIndex;
            btnRemove.Enabled = true;
            btnViaje.Enabled = true;
            btnVerViaje.Enabled = true;
        }
        private void ActualizarLista()
        {
            lbClientes.Items.Clear();
            for (int i = 0; i < sistema.CantClientes; i++)
            {
                Cliente aux = sistema.VerCliente(i);
                string texto = string.Format("Nombre:{0,-20} | DNI:{1,-10} | Tarjeta:{2,3} | Viajes:{3,2}", aux.Nombre, aux.Dni.ToString(), aux.Tarjeta.Codigo.ToString(), aux.Tarjeta.CantViajes.ToString());
                lbClientes.Items.Add(texto);
            }
        }

        private void btnVerViaje_Click(object sender, EventArgs e)
        {
            Cliente unCliente = sistema.VerCliente(i);
            lbClientes.Items.Clear();
            for(int i = 0; i < unCliente.Tarjeta.CantViajes; i++)
            {
                Viaje unViaje = unCliente.Tarjeta.VerViaje(i);
                lbClientes.Items.Add(string.Format("Codigo:{0,3}|Precio:{1,5}|Hr salida:{2,5}|Fecha:{3,5}",unViaje.CodigoLinea,unViaje.Precio,unViaje.Hora,unViaje.Fecha) );
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }
    }
}
