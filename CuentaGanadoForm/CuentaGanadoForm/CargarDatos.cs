using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class CargarDatos : Form
    {

        public CargarDatos()
        {
            InitializeComponent();

        }

        public string Dni
        {
            get { return this.tb_dni.Text; }
        }

        public string Nombre
        {
            get { return this.tb_nombre.Text; }
            set {  this.tb_nombre.Text = value; }
        }

        public string Edad
        {
            get { return this.tb_edad.Text; }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.tb_nombre.Text.Trim()))
            {
                MessageBox.Show("Nombre no valido");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
