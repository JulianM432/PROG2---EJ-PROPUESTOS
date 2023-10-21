namespace ParcialesProg2
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
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNroCliente = new System.Windows.Forms.TextBox();
            this.tbNroFactura = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEmpresa.Location = new System.Drawing.Point(200, 57);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(102, 23);
            this.btnCrearEmpresa.TabIndex = 0;
            this.btnCrearEmpresa.Text = "Crear Empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Location = new System.Drawing.Point(200, 86);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(102, 23);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Agregar Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnPago
            // 
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Location = new System.Drawing.Point(200, 115);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(102, 23);
            this.btnPago.TabIndex = 2;
            this.btnPago.Text = "Agregar Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nro Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nro Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto: $";
            // 
            // tbNroCliente
            // 
            this.tbNroCliente.Location = new System.Drawing.Point(80, 64);
            this.tbNroCliente.Name = "tbNroCliente";
            this.tbNroCliente.Size = new System.Drawing.Size(100, 20);
            this.tbNroCliente.TabIndex = 7;
            // 
            // tbNroFactura
            // 
            this.tbNroFactura.Location = new System.Drawing.Point(80, 90);
            this.tbNroFactura.Name = "tbNroFactura";
            this.tbNroFactura.Size = new System.Drawing.Size(100, 20);
            this.tbNroFactura.TabIndex = 8;
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(80, 116);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 161);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.tbNroFactura);
            this.Controls.Add(this.tbNroCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNroCliente;
        private System.Windows.Forms.TextBox tbNroFactura;
        private System.Windows.Forms.TextBox tbMonto;
    }
}

