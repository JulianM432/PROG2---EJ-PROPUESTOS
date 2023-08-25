using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBoleteria
{
    public partial class Form1 : Form
    {
        Boleteria boleteria = new Boleteria();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < boleteria.Cantidad; i++)
            {
                comboBox.Items.Add(boleteria.VerMicro(i).Destino);
            }
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            FormMicro formMicro = new FormMicro();
            if (formMicro.ShowDialog() == DialogResult.OK)
            {
                string destino, horario;
                int cantAsientos, codigo;
                double precio;
                destino = formMicro.tbDestino.Text;
                horario = formMicro.tbHorario.Text;
                precio = Convert.ToDouble(formMicro.tbPrecio.Text);
                cantAsientos = Convert.ToInt32(formMicro.tbCantAsientos.Text);
                codigo = Convert.ToInt32(formMicro.tbCodigo.Text);
                Micro unMicro = new Micro(destino, cantAsientos, precio, horario, codigo);
                boleteria.AgregarMicro(unMicro);
            }
            formMicro.Dispose();
        }
    }
}
