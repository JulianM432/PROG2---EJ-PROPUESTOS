using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Impresora
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument;
        public Form1()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            //printPreviewDialog = new PrintPreviewDialog();
            // Asigna el evento PrintPage al PrintDocument
            printDocument.PrintPage += printDocument1_PrintPage;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Asigna la configuración de impresión al PrintDocument
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                //Imprime
                printDocument.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Verdana", 14);
            Brush brush = new SolidBrush(Color.Black);
            Image logo = Bitmap.FromFile("..\\..\\logo.jpg");
            Image imgpropiedad = Bitmap.FromFile("..\\..\\GoletaDelMar.jpg");
            float x, y;
            int margen = 50, columnaX = 180;
            int ancho = e.PageBounds.Width - margen, alto = e.PageBounds.Height - margen;
            int h1 = 200, h2 = 300, h3 = 400;
            int hLinea = (int)font.GetHeight(e.Graphics);
            x = y = margen;

            // Encabezado
            int medidaAux = e.PageBounds.Width / 3;
            g.DrawImage(logo, x, y, medidaAux, h1);
            ancho -= margen;
            g.DrawRectangle(pen, x, y, ancho, h1);
            g.DrawRectangle(pen, x, y, medidaAux, h1);
            g.DrawString("Rentify S.A. - UTN FRP", font, brush, x + 20, h1 + y / 2);
            g.DrawString("FACTURA/RESERVA\nNro Factura: 9032839012\nNombre_Cliente\nCUIL: xx-xxxxxxxx-x\nFECHA DE EMISION: " + DateTime.Now.ToShortDateString(), font, brush, margen + medidaAux + 20, y + 20);

            // LISTADO DE PERSONAS
            y += h1;
            g.DrawRectangle(pen, x, y, ancho, (int)font.GetHeight(e.Graphics)); // Columnas de huesped
            string[][] text = { new string[] { "Nombre", "Apellido", "Documento", "Fecha Nacimiento" },
                                new string[] {"aaaaaa","bbbbbb","22000000","01/01/01" },
                                new string[] {"eeeeee","fdsf","11111111","10/10/20"},
                                new string[] {"ssssss","asdw","22222222","01/02/03"},
                                new string[] {"dddddd","dsadas","33333333","02/03/04"},
                                new string[] {"www","eqwe","44444444","09/12/18"}};
            foreach (string[] s in text)
            {
                x = margen + 5;
                foreach (string txt in s)
                {
                    g.DrawString(txt, font, brush, x, y);
                    x += columnaX;
                }
                y += hLinea;
            }
            y = margen + h1 + hLinea;
            x = margen;
            g.DrawRectangle(pen, x, y, ancho, h2); // Fin lista de huespedes

            //DATOS DE LA PROPIEDAD RESERVADA
            y += h2;
            g.DrawImage(imgpropiedad, x, y, h3, h3);
            g.DrawRectangle(pen, x, y, h3, h3);
            g.DrawString("Tipo_Propiedad\nNombre_Propiedad\nUbicacion_Propiedad\nCapacidad_Propiedad" +
                "\nServicios:\n->\n->\n->", font, brush, x + h3 + 10, y);
            y += h3;
            g.DrawLine(pen, x, y, ancho + x, y);
            g.DrawString("Fecha de reserva: " + DateTime.Now.ToShortDateString() + " - " + DateTime.Now.AddDays(3).ToShortDateString()
                + "\nCantidad de dias: x dias\nCosto base: $ x", font, brush, x, y);
            x = margen + h3;
            y += hLinea * 2; // 2 renglones mas

            g.DrawRectangle(pen, x, y, ancho - x + margen, alto - y);
            g.DrawString("Costo total: $ x", new Font("Verdana", 14, FontStyle.Bold), brush, x + 5, y + 5);
            //MARCO
            g.DrawRectangle(pen, margen, margen, ancho, alto - margen);
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
