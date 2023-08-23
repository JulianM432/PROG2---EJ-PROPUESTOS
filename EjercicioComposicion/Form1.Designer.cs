namespace EjercicioComposicion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.lbJuego = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(12, 12);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(396, 13);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(75, 23);
            this.btnSimulacion.TabIndex = 1;
            this.btnSimulacion.Text = "Simular";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // lbJuego
            // 
            this.lbJuego.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJuego.FormattingEnabled = true;
            this.lbJuego.ItemHeight = 15;
            this.lbJuego.Location = new System.Drawing.Point(13, 42);
            this.lbJuego.Name = "lbJuego";
            this.lbJuego.Size = new System.Drawing.Size(458, 169);
            this.lbJuego.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 224);
            this.Controls.Add(this.lbJuego);
            this.Controls.Add(this.btnSimulacion);
            this.Controls.Add(this.btnJugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.ListBox lbJuego;
    }
}

