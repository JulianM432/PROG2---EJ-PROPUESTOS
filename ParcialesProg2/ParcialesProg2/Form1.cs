using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialesProg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema;
        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            Fempresa fEmpresa = new Fempresa();
            if (fEmpresa.ShowDialog() == DialogResult.OK)
            {
                long cuit = Convert.ToInt64(fEmpresa.tbCuit.Text);
                sistema = new Sistema(cuit, fEmpresa.tbNombreEmpresa.Text);
                sistema.AgregarCliente(new Cliente(100, "Juan"));
                sistema.AgregarCliente(new Cliente(110, "Jorge"));
                sistema.AgregarCliente(new ClienteCuenta(120, "Maria"));
                sistema.AgregarCliente(new ClienteCuenta(130, "Marta"));
                for (int i = 0; i < sistema.CantClientes; i++)
                {
                    Cliente c = sistema.VerCliente(i);
                    comboBox1.Items.Add(string.Format("{0,5} | {1,-10}", c.NroCliente, c.Nombre));
                }
            }
            fEmpresa.Dispose();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            int nroCliente = Convert.ToInt32(tbNroCliente.Text);
            int nroFactura = Convert.ToInt32(tbNroFactura.Text);
            double monto = Convert.ToDouble(tbMonto.Text);
            if (!sistema.AgregarFactura(nroCliente, nroFactura, monto))
            {
                MessageBox.Show("No se pudo realizar la operacion");
            }
            tbMonto.Clear();
            tbNroCliente.Clear();
            tbNroFactura.Clear();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            int nroCliente = Convert.ToInt32(tbNroCliente.Text);
            double monto = Convert.ToDouble(tbMonto.Text);
            if (!sistema.AgregarPago(nroCliente,monto))
            {
                MessageBox.Show("No se pudo realizar la operacion");
            }
            else
            {
                MessageBox.Show("Saldo: " + sistema.VerSaldo(nroCliente).VerSaldo().ToString("0.00") );
            }
            tbMonto.Clear();
            tbNroCliente.Clear();
        }
    }
}
