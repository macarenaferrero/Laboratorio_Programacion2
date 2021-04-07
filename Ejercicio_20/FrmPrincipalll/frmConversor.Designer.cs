namespace FrmPrincipalll
{
    partial class frmConversor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversor));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCandado = new System.Windows.Forms.Button();
            this.imlCandado = new System.Windows.Forms.ImageList(this.components);
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.txtConvertEuroToEuro = new System.Windows.Forms.TextBox();
            this.txtConvertDolarToEuro = new System.Windows.Forms.TextBox();
            this.txtConvertPesoToEuro = new System.Windows.Forms.TextBox();
            this.txtConvertEuroToDolar = new System.Windows.Forms.TextBox();
            this.txtConvertDolarToDolar = new System.Windows.Forms.TextBox();
            this.txtConvertPesoToDolar = new System.Windows.Forms.TextBox();
            this.txtConvertEuroToPeso = new System.Windows.Forms.TextBox();
            this.txtConvertDolarToPeso = new System.Windows.Forms.TextBox();
            this.txtConvertPesoToPeso = new System.Windows.Forms.TextBox();
            this.lblConvertEuro = new System.Windows.Forms.Label();
            this.lblConvertDolar = new System.Windows.Forms.Label();
            this.lblConvertPeso = new System.Windows.Forms.Label();
            this.txtbxConverEuro = new System.Windows.Forms.TextBox();
            this.txtbxConverDolar = new System.Windows.Forms.TextBox();
            this.txtbxConverPeso = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(88, 22);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(56, 13);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(13, 79);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 111);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(14, 142);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // btnCandado
            // 
            this.btnCandado.ImageIndex = 0;
            this.btnCandado.ImageList = this.imlCandado;
            this.btnCandado.Location = new System.Drawing.Point(150, 12);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(75, 23);
            this.btnCandado.TabIndex = 5;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // imlCandado
            // 
            this.imlCandado.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCandado.ImageStream")));
            this.imlCandado.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCandado.Images.SetKeyName(0, "pngkit_logout-icon-png_2715478 (1).png");
            this.imlCandado.Images.SetKeyName(1, "—Pngtree—vector lock icon_3782160.png");
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(151, 69);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(75, 23);
            this.btnEuro.TabIndex = 8;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(151, 101);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 9;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(151, 134);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(75, 23);
            this.btnPeso.TabIndex = 10;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // txtConvertEuroToEuro
            // 
            this.txtConvertEuroToEuro.Enabled = false;
            this.txtConvertEuroToEuro.Location = new System.Drawing.Point(231, 72);
            this.txtConvertEuroToEuro.Name = "txtConvertEuroToEuro";
            this.txtConvertEuroToEuro.Size = new System.Drawing.Size(79, 20);
            this.txtConvertEuroToEuro.TabIndex = 14;
            // 
            // txtConvertDolarToEuro
            // 
            this.txtConvertDolarToEuro.Enabled = false;
            this.txtConvertDolarToEuro.Location = new System.Drawing.Point(232, 104);
            this.txtConvertDolarToEuro.Name = "txtConvertDolarToEuro";
            this.txtConvertDolarToEuro.Size = new System.Drawing.Size(78, 20);
            this.txtConvertDolarToEuro.TabIndex = 15;
            // 
            // txtConvertPesoToEuro
            // 
            this.txtConvertPesoToEuro.Enabled = false;
            this.txtConvertPesoToEuro.Location = new System.Drawing.Point(231, 134);
            this.txtConvertPesoToEuro.Name = "txtConvertPesoToEuro";
            this.txtConvertPesoToEuro.Size = new System.Drawing.Size(79, 20);
            this.txtConvertPesoToEuro.TabIndex = 16;
            // 
            // txtConvertEuroToDolar
            // 
            this.txtConvertEuroToDolar.Enabled = false;
            this.txtConvertEuroToDolar.Location = new System.Drawing.Point(317, 71);
            this.txtConvertEuroToDolar.Name = "txtConvertEuroToDolar";
            this.txtConvertEuroToDolar.Size = new System.Drawing.Size(76, 20);
            this.txtConvertEuroToDolar.TabIndex = 17;
            // 
            // txtConvertDolarToDolar
            // 
            this.txtConvertDolarToDolar.Enabled = false;
            this.txtConvertDolarToDolar.Location = new System.Drawing.Point(317, 103);
            this.txtConvertDolarToDolar.Name = "txtConvertDolarToDolar";
            this.txtConvertDolarToDolar.Size = new System.Drawing.Size(76, 20);
            this.txtConvertDolarToDolar.TabIndex = 18;
            // 
            // txtConvertPesoToDolar
            // 
            this.txtConvertPesoToDolar.Enabled = false;
            this.txtConvertPesoToDolar.Location = new System.Drawing.Point(316, 133);
            this.txtConvertPesoToDolar.Name = "txtConvertPesoToDolar";
            this.txtConvertPesoToDolar.Size = new System.Drawing.Size(77, 20);
            this.txtConvertPesoToDolar.TabIndex = 19;
            // 
            // txtConvertEuroToPeso
            // 
            this.txtConvertEuroToPeso.Enabled = false;
            this.txtConvertEuroToPeso.Location = new System.Drawing.Point(399, 71);
            this.txtConvertEuroToPeso.Name = "txtConvertEuroToPeso";
            this.txtConvertEuroToPeso.Size = new System.Drawing.Size(77, 20);
            this.txtConvertEuroToPeso.TabIndex = 20;
            // 
            // txtConvertDolarToPeso
            // 
            this.txtConvertDolarToPeso.Enabled = false;
            this.txtConvertDolarToPeso.Location = new System.Drawing.Point(399, 103);
            this.txtConvertDolarToPeso.Name = "txtConvertDolarToPeso";
            this.txtConvertDolarToPeso.Size = new System.Drawing.Size(77, 20);
            this.txtConvertDolarToPeso.TabIndex = 21;
            // 
            // txtConvertPesoToPeso
            // 
            this.txtConvertPesoToPeso.Enabled = false;
            this.txtConvertPesoToPeso.Location = new System.Drawing.Point(399, 133);
            this.txtConvertPesoToPeso.Name = "txtConvertPesoToPeso";
            this.txtConvertPesoToPeso.Size = new System.Drawing.Size(77, 20);
            this.txtConvertPesoToPeso.TabIndex = 22;
            // 
            // lblConvertEuro
            // 
            this.lblConvertEuro.AutoSize = true;
            this.lblConvertEuro.Location = new System.Drawing.Point(253, 56);
            this.lblConvertEuro.Name = "lblConvertEuro";
            this.lblConvertEuro.Size = new System.Drawing.Size(29, 13);
            this.lblConvertEuro.TabIndex = 23;
            this.lblConvertEuro.Text = "Euro";
            // 
            // lblConvertDolar
            // 
            this.lblConvertDolar.AutoSize = true;
            this.lblConvertDolar.Location = new System.Drawing.Point(340, 55);
            this.lblConvertDolar.Name = "lblConvertDolar";
            this.lblConvertDolar.Size = new System.Drawing.Size(32, 13);
            this.lblConvertDolar.TabIndex = 24;
            this.lblConvertDolar.Text = "Dolar";
            // 
            // lblConvertPeso
            // 
            this.lblConvertPeso.AutoSize = true;
            this.lblConvertPeso.Location = new System.Drawing.Point(423, 55);
            this.lblConvertPeso.Name = "lblConvertPeso";
            this.lblConvertPeso.Size = new System.Drawing.Size(31, 13);
            this.lblConvertPeso.TabIndex = 25;
            this.lblConvertPeso.Text = "Peso";
            // 
            // txtbxConverEuro
            // 
            this.txtbxConverEuro.Location = new System.Drawing.Point(232, 14);
            this.txtbxConverEuro.Name = "txtbxConverEuro";
            this.txtbxConverEuro.Size = new System.Drawing.Size(78, 20);
            this.txtbxConverEuro.TabIndex = 26;
            this.txtbxConverEuro.Leave += new System.EventHandler(this.txtbxConverEuro_Leave);
            // 
            // txtbxConverDolar
            // 
            this.txtbxConverDolar.Location = new System.Drawing.Point(317, 14);
            this.txtbxConverDolar.Name = "txtbxConverDolar";
            this.txtbxConverDolar.Size = new System.Drawing.Size(76, 20);
            this.txtbxConverDolar.TabIndex = 27;
            this.txtbxConverDolar.Leave += new System.EventHandler(this.txtbxConverDolar_Leave);
            // 
            // txtbxConverPeso
            // 
            this.txtbxConverPeso.Location = new System.Drawing.Point(399, 14);
            this.txtbxConverPeso.Name = "txtbxConverPeso";
            this.txtbxConverPeso.Size = new System.Drawing.Size(76, 20);
            this.txtbxConverPeso.TabIndex = 28;
            this.txtbxConverPeso.Leave += new System.EventHandler(this.txtbxConverPeso_Leave);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(61, 71);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(74, 20);
            this.txtEuro.TabIndex = 29;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(61, 103);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(74, 20);
            this.txtDolar.TabIndex = 30;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(61, 136);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(74, 20);
            this.txtPeso.TabIndex = 31;
            // 
            // frmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 169);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtbxConverPeso);
            this.Controls.Add(this.txtbxConverDolar);
            this.Controls.Add(this.txtbxConverEuro);
            this.Controls.Add(this.lblConvertPeso);
            this.Controls.Add(this.lblConvertDolar);
            this.Controls.Add(this.lblConvertEuro);
            this.Controls.Add(this.txtConvertPesoToPeso);
            this.Controls.Add(this.txtConvertDolarToPeso);
            this.Controls.Add(this.txtConvertEuroToPeso);
            this.Controls.Add(this.txtConvertPesoToDolar);
            this.Controls.Add(this.txtConvertDolarToDolar);
            this.Controls.Add(this.txtConvertEuroToDolar);
            this.Controls.Add(this.txtConvertPesoToEuro);
            this.Controls.Add(this.txtConvertDolarToEuro);
            this.Controls.Add(this.txtConvertEuroToEuro);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.ImageList imlCandado;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.TextBox txtConvertEuroToEuro;
        private System.Windows.Forms.TextBox txtConvertDolarToEuro;
        private System.Windows.Forms.TextBox txtConvertPesoToEuro;
        private System.Windows.Forms.TextBox txtConvertEuroToDolar;
        private System.Windows.Forms.TextBox txtConvertDolarToDolar;
        private System.Windows.Forms.TextBox txtConvertPesoToDolar;
        private System.Windows.Forms.TextBox txtConvertEuroToPeso;
        private System.Windows.Forms.TextBox txtConvertDolarToPeso;
        private System.Windows.Forms.TextBox txtConvertPesoToPeso;
        private System.Windows.Forms.Label lblConvertEuro;
        private System.Windows.Forms.Label lblConvertDolar;
        private System.Windows.Forms.Label lblConvertPeso;
        private System.Windows.Forms.TextBox txtbxConverEuro;
        private System.Windows.Forms.TextBox txtbxConverDolar;
        private System.Windows.Forms.TextBox txtbxConverPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
    }
}