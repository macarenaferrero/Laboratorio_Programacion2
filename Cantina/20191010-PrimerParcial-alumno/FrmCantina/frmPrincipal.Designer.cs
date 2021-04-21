namespace FrmCantina
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.nUDCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nUDContenido = new System.Windows.Forms.NumericUpDown();
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(182, 405);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmbBotellaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Items.AddRange(new object[] {
            "Vidrio,",
            "Plastico"});
            this.cmbBotellaTipo.Location = new System.Drawing.Point(435, 425);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 1;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(435, 409);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 2;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(435, 450);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(182, 446);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(272, 446);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 5;
            this.lblContenido.Text = "Contenido";
            // 
            // nUDCapacidad
            // 
            this.nUDCapacidad.Location = new System.Drawing.Point(185, 463);
            this.nUDCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nUDCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCapacidad.Name = "nUDCapacidad";
            this.nUDCapacidad.Size = new System.Drawing.Size(58, 20);
            this.nUDCapacidad.TabIndex = 6;
            this.nUDCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nUDContenido
            // 
            this.nUDContenido.Location = new System.Drawing.Point(275, 463);
            this.nUDContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nUDContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDContenido.Name = "nUDContenido";
            this.nUDContenido.Size = new System.Drawing.Size(56, 20);
            this.nUDContenido.TabIndex = 7;
            this.nUDContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(12, 405);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbCerveza.TabIndex = 8;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(185, 422);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(147, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(12, 442);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 10;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(10, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 505);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.rbCerveza);
            this.Controls.Add(this.nUDContenido);
            this.Controls.Add(this.nUDCapacidad);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumna Macarena Ferrero";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.NumericUpDown nUDCapacidad;
        private System.Windows.Forms.NumericUpDown nUDContenido;
        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.RadioButton rbAgua;
        private ControlCantina.Barra barra1;
    }
}

