using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
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
        Contenedor contenedor = new Contenedor();
        List<string[]> fuente = new List<string[]>();
        int nroLinea = 0;
        //Image img = Bitmap.FromFile("C:\\Users\\Julian\\Desktop\\imagenes\\GoletaDelMar.jpg");
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Point point = new Point(100,100);
            //string line = "Hola mundo";
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Green);
            Font font = new Font("Arial", 12);
            #region STRING
            //Control de lineas por paginas
            int hLine = Convert.ToInt32(font.GetHeight(e.Graphics));
            int cantLinePag = Convert.ToInt32(e.MarginBounds.Height / hLine); // ( Altura de la pagina / alturaLinea )

            //Impresion de la cabecera
            int x = 20;
            int y = hLine;
            g.DrawRectangle(new Pen(Color.Black),new Rectangle(x,y,(e.MarginBounds.Width),(e.MarginBounds.Height)) );
            y += hLine;
            g.DrawString("DNI", font, brush, x, y);
            g.DrawString("APELLIDO Y NOMBRE", font, brush, x + 200, y);

            //Impresion de la consulta
            int nroEnPagActual = 0;
            while (nroEnPagActual < (cantLinePag - 2) && nroLinea < fuente.Count)
            {
                //Dibujo
                y += hLine;
                g.DrawString((fuente[nroLinea])[0], font, brush, x, y);
                g.DrawString((fuente[nroLinea])[1], font, brush, x + 200, y);

                //Siguiente linea
                nroLinea++;
                nroEnPagActual++;
            }
            //Verifica si vuelve a llamar al print para la siguiente pagina
            if (nroLinea < fuente.Count)
            {
                e.HasMorePages = true;
            }
            #endregion
            //g.DrawImage(img, new Rectangle(x,y + hLine,50,50) );
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //    printDialog1.Dispose();
            //}
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printPreviewDialog1.Dispose();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            nroLinea = 0;
            fuente = contenedor.Listar();
        }
    }
}
