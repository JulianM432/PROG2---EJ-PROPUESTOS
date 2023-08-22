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
            this.btnVerViaje = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.btnViaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labCantClientes = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar Cliente";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(10, 174);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 45);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover Cliente";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnVerViaje
            // 
            this.btnVerViaje.Location = new System.Drawing.Point(10, 223);
            this.btnVerViaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerViaje.Name = "btnVerViaje";
            this.btnVerViaje.Size = new System.Drawing.Size(86, 45);
            this.btnVerViaje.TabIndex = 2;
            this.btnVerViaje.Text = "Ver viajes";
            this.btnVerViaje.UseVisualStyleBackColor = true;
            this.btnVerViaje.Click += new System.EventHandler(this.btnVerViaje_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 15;
            this.lbClientes.Location = new System.Drawing.Point(101, 10);
            this.lbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(649, 319);
            this.lbClientes.TabIndex = 3;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // btnViaje
            // 
            this.btnViaje.Location = new System.Drawing.Point(11, 125);
            this.btnViaje.Margin = new System.Windows.Forms.Padding(2);
            this.btnViaje.Name = "btnViaje";
            this.btnViaje.Size = new System.Drawing.Size(86, 45);
            this.btnViaje.TabIndex = 4;
            this.btnViaje.Text = "Agregar Viaje";
            this.btnViaje.UseVisualStyleBackColor = true;
            this.btnViaje.Click += new System.EventHandler(this.btnViaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes:";
            // 
            // labCantClientes
            // 
            this.labCantClientes.AutoSize = true;
            this.labCantClientes.Location = new System.Drawing.Point(11, 30);
            this.labCantClientes.Name = "labCantClientes";
            this.labCantClientes.Size = new System.Drawing.Size(10, 13);
            this.labCantClientes.TabIndex = 6;
            this.labCantClientes.Text = " ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 42);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Actualizar Lista";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 340);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labCantClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViaje);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.btnVerViaje);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnVerViaje;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Button btnViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCantClientes;
        private System.Windows.Forms.Button btnUpdate;
    }
}

