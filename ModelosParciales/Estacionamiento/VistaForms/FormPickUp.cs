using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForms
{
    public partial class FormPickUp : Form
    {
        public FormPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPatente.Text) && !String.IsNullOrWhiteSpace(txtModelo.Text) && txtPatente.Text.Length == 6)
            {
                PickUp auxPickUp = new PickUp(txtPatente.Text, txtModelo.Text);
                MessageBox.Show(auxPickUp.ConsultarDatos(),"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                MessageBox.Show("Error en los datos ingresados");
            }



        }
    }
}
