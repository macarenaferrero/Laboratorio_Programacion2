
namespace CuentaGanadoForm
{
    partial class CargarDatos
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.lb_edad = new System.Windows.Forms.Label();
            this.tb_edad = new System.Windows.Forms.TextBox();
            this.lb_dni = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(241, 253);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(219, 81);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(237, 74);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(79, 20);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "NOMBRE";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(341, 74);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 26);
            this.tb_nombre.TabIndex = 2;
            // 
            // lb_edad
            // 
            this.lb_edad.AutoSize = true;
            this.lb_edad.Location = new System.Drawing.Point(237, 138);
            this.lb_edad.Name = "lb_edad";
            this.lb_edad.Size = new System.Drawing.Size(55, 20);
            this.lb_edad.TabIndex = 3;
            this.lb_edad.Text = "EDAD";
            // 
            // tb_edad
            // 
            this.tb_edad.Location = new System.Drawing.Point(341, 138);
            this.tb_edad.Name = "tb_edad";
            this.tb_edad.Size = new System.Drawing.Size(100, 26);
            this.tb_edad.TabIndex = 4;
            // 
            // lb_dni
            // 
            this.lb_dni.AutoSize = true;
            this.lb_dni.Location = new System.Drawing.Point(237, 184);
            this.lb_dni.Name = "lb_dni";
            this.lb_dni.Size = new System.Drawing.Size(37, 20);
            this.lb_dni.TabIndex = 5;
            this.lb_dni.Text = "DNI";
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(341, 196);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(100, 26);
            this.tb_dni.TabIndex = 6;
            // 
            // CargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.lb_dni);
            this.Controls.Add(this.tb_edad);
            this.Controls.Add(this.lb_edad);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "CargarDatos";
            this.Text = "CargarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label lb_edad;
        private System.Windows.Forms.TextBox tb_edad;
        private System.Windows.Forms.Label lb_dni;
        private System.Windows.Forms.TextBox tb_dni;
    }
}