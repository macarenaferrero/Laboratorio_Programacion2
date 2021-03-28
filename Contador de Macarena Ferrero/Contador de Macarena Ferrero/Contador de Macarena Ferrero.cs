using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_Macarena_Ferrero
{
    public partial class CuentaGanadoForm : Form
    {
        private Bar miBar;

        public Bar MiBar
        {
            get { return MiBar; }
            set { MiBar = value; }

        }

        public CuentaGanadoForm()
        {
            InitializeComponent();
        }

        private void informe_Click(object sender, EventArgs e)
        {
            int cantEmpleados = Convert.ToInt32(cantEmpl.Text);
            int cantGentes = Convert.ToInt32(cantGente.Text);
            if (cantEmpleados > cantGentes)
            {
                Form auxForm = new Form();

            }
        }

        private void cantGente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
