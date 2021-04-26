namespace FrmPrincipal
{
    partial class FrmJardin
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
            this.richTxBJardin = new System.Windows.Forms.RichTextBox();
            this.btnDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxBJardin
            // 
            this.richTxBJardin.Location = new System.Drawing.Point(12, 60);
            this.richTxBJardin.Name = "richTxBJardin";
            this.richTxBJardin.Size = new System.Drawing.Size(580, 214);
            this.richTxBJardin.TabIndex = 0;
            this.richTxBJardin.Text = "";
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(476, 12);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(116, 37);
            this.btnDatos.TabIndex = 1;
            this.btnDatos.Text = "Ver datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // FrmJardin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(604, 286);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.richTxBJardin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJardin";
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.FrmJardin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxBJardin;
        private System.Windows.Forms.Button btnDatos;
    }
}

