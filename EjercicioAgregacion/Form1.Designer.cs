namespace EjercicioAgregacion
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTeam = new System.Windows.Forms.GroupBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(175, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 60);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Jugador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(162, 13);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnEquipo.TabIndex = 1;
            this.btnEquipo.Text = "Nombrar";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(65, 65);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 3;
            // 
            // tbNro
            // 
            this.tbNro.Location = new System.Drawing.Point(65, 102);
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(100, 20);
            this.tbNro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nro:";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnLista);
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.tbDNI);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.tbNro);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 61);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(243, 132);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(277, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(427, 184);
            this.listBox1.TabIndex = 7;
            // 
            // tbEquipo
            // 
            this.tbEquipo.Location = new System.Drawing.Point(56, 13);
            this.tbEquipo.Name = "tbEquipo";
            this.tbEquipo.Size = new System.Drawing.Size(100, 20);
            this.tbEquipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre:";
            // 
            // gbTeam
            // 
            this.gbTeam.Controls.Add(this.tbEquipo);
            this.gbTeam.Controls.Add(this.label4);
            this.gbTeam.Controls.Add(this.btnEquipo);
            this.gbTeam.Location = new System.Drawing.Point(12, 12);
            this.gbTeam.Name = "gbTeam";
            this.gbTeam.Size = new System.Drawing.Size(243, 43);
            this.gbTeam.TabIndex = 10;
            this.gbTeam.TabStop = false;
            this.gbTeam.Text = "Equipo:";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(175, 87);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(62, 39);
            this.btnLista.TabIndex = 6;
            this.btnLista.Text = "Listar";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 202);
            this.Controls.Add(this.gbTeam);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbDatos);
            this.Name = "Form1";
            this.Text = "Equipo de buena fe";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbTeam.ResumeLayout(false);
            this.gbTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEquipo;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDNI;
        public System.Windows.Forms.TextBox tbNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbEquipo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gbTeam;
        private System.Windows.Forms.Button btnLista;
    }
}

