namespace Libreria
{
    partial class FrmTest
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
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.btnVendeer = new System.Windows.Forms.Button();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rtbInforme
            // 
            this.rtbInforme.Enabled = false;
            this.rtbInforme.Location = new System.Drawing.Point(308, 13);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(230, 425);
            this.rtbInforme.TabIndex = 0;
            this.rtbInforme.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(276, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(12, 352);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(276, 40);
            this.btnVerInforme.TabIndex = 2;
            this.btnVerInforme.Text = "Ver Informe";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // btnVendeer
            // 
            this.btnVendeer.Location = new System.Drawing.Point(12, 306);
            this.btnVendeer.Name = "btnVendeer";
            this.btnVendeer.Size = new System.Drawing.Size(276, 40);
            this.btnVendeer.TabIndex = 3;
            this.btnVendeer.Text = "Vender";
            this.btnVendeer.UseVisualStyleBackColor = true;
            this.btnVendeer.Click += new System.EventHandler(this.btnVendeer_Click);
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(12, 13);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(276, 277);
            this.lstStock.TabIndex = 4;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.btnVendeer);
            this.Controls.Add(this.btnVerInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester Macarena Ferrero 2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTest_FormClosing);
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Button btnVendeer;
        private System.Windows.Forms.ListBox lstStock;
    }
}

