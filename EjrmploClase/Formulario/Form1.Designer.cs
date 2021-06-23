namespace Formulario
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
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstCobrado = new System.Windows.Forms.ListBox();
            this.lstAtendido = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(12, 15);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(265, 277);
            this.lstIngresado.TabIndex = 0;
            // 
            // lstCobrado
            // 
            this.lstCobrado.FormattingEnabled = true;
            this.lstCobrado.Location = new System.Drawing.Point(283, 15);
            this.lstCobrado.Name = "lstCobrado";
            this.lstCobrado.Size = new System.Drawing.Size(265, 277);
            this.lstCobrado.TabIndex = 1;
            // 
            // lstAtendido
            // 
            this.lstAtendido.FormattingEnabled = true;
            this.lstAtendido.Location = new System.Drawing.Point(554, 15);
            this.lstAtendido.Name = "lstAtendido";
            this.lstAtendido.Size = new System.Drawing.Size(265, 277);
            this.lstAtendido.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cobrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstAtendido);
            this.Controls.Add(this.lstCobrado);
            this.Controls.Add(this.lstIngresado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.ListBox lstCobrado;
        private System.Windows.Forms.ListBox lstAtendido;
        private System.Windows.Forms.Button button1;
    }
}

