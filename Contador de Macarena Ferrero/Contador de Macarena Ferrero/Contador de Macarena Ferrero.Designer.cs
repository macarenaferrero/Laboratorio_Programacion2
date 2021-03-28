namespace Contador_de_Macarena_Ferrero
{
    partial class CuentaGanadoForm
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
            this.Informe = new System.Windows.Forms.Button();
            this.CantEmpleados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantEmpl = new System.Windows.Forms.ComboBox();
            this.cantGente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Informe
            // 
            this.Informe.Location = new System.Drawing.Point(481, 294);
            this.Informe.Name = "Informe";
            this.Informe.Size = new System.Drawing.Size(75, 23);
            this.Informe.TabIndex = 0;
            this.Informe.Text = "INFORME";
            this.Informe.UseVisualStyleBackColor = true;
            this.Informe.Click += new System.EventHandler(this.informe_Click);
            // 
            // CantEmpleados
            // 
            this.CantEmpleados.AutoSize = true;
            this.CantEmpleados.Location = new System.Drawing.Point(52, 45);
            this.CantEmpleados.Name = "CantEmpleados";
            this.CantEmpleados.Size = new System.Drawing.Size(59, 13);
            this.CantEmpleados.TabIndex = 1;
            this.CantEmpleados.Text = "Empleados";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gente";
            // 
            // cantEmpl
            // 
            this.cantEmpl.FormattingEnabled = true;
            this.cantEmpl.Location = new System.Drawing.Point(192, 37);
            this.cantEmpl.Name = "cantEmpl";
            this.cantEmpl.Size = new System.Drawing.Size(121, 21);
            this.cantEmpl.TabIndex = 5;
            // 
            // cantGente
            // 
            this.cantGente.FormattingEnabled = true;
            this.cantGente.Location = new System.Drawing.Point(192, 125);
            this.cantGente.Name = "cantGente";
            this.cantGente.Size = new System.Drawing.Size(121, 21);
            this.cantGente.TabIndex = 6;
            this.cantGente.SelectedIndexChanged += new System.EventHandler(this.cantGente_SelectedIndexChanged);
            // 
            // CuentaGanadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 347);
            this.Controls.Add(this.cantGente);
            this.Controls.Add(this.cantEmpl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantEmpleados);
            this.Controls.Add(this.Informe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentaGanadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Macarena Ferrero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Informe;
        private System.Windows.Forms.Label CantEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cantEmpl;
        private System.Windows.Forms.ComboBox cantGente;
    }
}

