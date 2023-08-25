namespace EjercicioBoleteria
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbMicro = new System.Windows.Forms.ListBox();
            this.lbAsientos = new System.Windows.Forms.ListBox();
            this.btnMicro = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(139, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbMicro
            // 
            this.lbMicro.FormattingEnabled = true;
            this.lbMicro.Location = new System.Drawing.Point(93, 39);
            this.lbMicro.Name = "lbMicro";
            this.lbMicro.Size = new System.Drawing.Size(279, 95);
            this.lbMicro.TabIndex = 1;
            // 
            // lbAsientos
            // 
            this.lbAsientos.FormattingEnabled = true;
            this.lbAsientos.Location = new System.Drawing.Point(378, 39);
            this.lbAsientos.Name = "lbAsientos";
            this.lbAsientos.Size = new System.Drawing.Size(120, 95);
            this.lbAsientos.TabIndex = 2;
            // 
            // btnMicro
            // 
            this.btnMicro.Location = new System.Drawing.Point(12, 39);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(75, 46);
            this.btnMicro.TabIndex = 3;
            this.btnMicro.Text = "Micros";
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.Click += new System.EventHandler(this.btnMicro_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 141);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnMicro);
            this.Controls.Add(this.lbAsientos);
            this.Controls.Add(this.lbMicro);
            this.Controls.Add(this.btnConsultar);
            this.Name = "Form1";
            this.Text = "Boleteria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lbMicro;
        private System.Windows.Forms.ListBox lbAsientos;
        private System.Windows.Forms.Button btnMicro;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

