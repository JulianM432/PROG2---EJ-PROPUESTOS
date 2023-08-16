namespace EjercicioEntregable
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.btnViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar Cliente";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 57);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 39);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover Cliente";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Location = new System.Drawing.Point(12, 102);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(115, 46);
            this.btnGestion.TabIndex = 2;
            this.btnGestion.Text = "Gestionar Clientes";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 16;
            this.lbClientes.Location = new System.Drawing.Point(133, 12);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(353, 404);
            this.lbClientes.TabIndex = 3;
            // 
            // btnViaje
            // 
            this.btnViaje.Location = new System.Drawing.Point(12, 154);
            this.btnViaje.Name = "btnViaje";
            this.btnViaje.Size = new System.Drawing.Size(115, 38);
            this.btnViaje.TabIndex = 4;
            this.btnViaje.Text = "Agregar Viaje";
            this.btnViaje.UseVisualStyleBackColor = true;
            this.btnViaje.Click += new System.EventHandler(this.btnViaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 423);
            this.Controls.Add(this.btnViaje);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Button btnViaje;
    }
}

