using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monedas;

namespace FrmPrincipalll
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();

            txtbxConverEuro.Text = Euro.GetCotizacion().ToString();
            txtbxConverPeso.Text = Pesos.GetCotizacion().ToString();
            txtbxConverDolar.Text = Dolar.GetCotizacion().ToString();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            btnCandado.ImageIndex = 1;
            if (btnCandado.ImageIndex == 1)
            {
                txtbxConverDolar.Enabled = false;
                txtbxConverEuro.Enabled = false;
                txtbxConverPeso.Enabled = false;
            }
            else
            {
                btnCandado.ImageIndex = 0;
                txtbxConverDolar.Enabled = true;
                txtbxConverEuro.Enabled = true;
                txtbxConverPeso.Enabled = true;

            }

        }


        private void txtbxConverDolar_Leave(object sender, EventArgs e)
        {
            if (txtbxConverDolar.Text != "1")
            {
                txtbxConverDolar.Text = "1";
            }
            double aux = 0;
            if (double.TryParse(txtbxConverDolar.Text, out aux))
                Dolar.SetCotizacion(aux);
            else
                txtbxConverDolar.Focus();
        }

        private void txtbxConverEuro_Leave(object sender, EventArgs e)
        {
            if (txtbxConverEuro.Text != "1.08")
            {
                txtbxConverEuro.Text = "1.08";
            }
            double aux = 0;
            if (double.TryParse(txtbxConverEuro.Text, out aux))
                Euro.SetCotizacion(aux);
            else
                txtbxConverEuro.Focus();
        }

        private void txtbxConverPeso_Leave(object sender, EventArgs e)
        {
            if (txtbxConverPeso.Text != "66")
            {
                txtbxConverPeso.Text = "66";
            }

            double aux = 0;
            if (double.TryParse(txtbxConverPeso.Text, out aux))
                Pesos.SetCotizacion(aux);
            else
                txtbxConverPeso.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            if (txtEuro.Text != null)
            {
                double valorP = 0;
                if (double.TryParse(txtPeso.Text, out valorP))
                {
                    Euro moneda = new Euro(valorP);

                    txtConvertEuroToEuro.Text = moneda.GetCantidad().ToString();
                    txtConvertEuroToDolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                    txtConvertEuroToPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
                }

            }

        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            if (txtDolar.Text != null)
            {
                double valorD = 0;
                if (double.TryParse(txtDolar.Text, out valorD))
                {
                    Dolar moneda = new Dolar(valorD);

                    txtConvertDolarToDolar.Text = moneda.GetCantidad().ToString();
                    txtConvertDolarToEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                    txtConvertDolarToPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
                }
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text != null)
            {
                double valorP = 0;
                if (double.TryParse(txtDolar.Text, out valorP))
                {
                    Pesos moneda = new Pesos(valorP);

                    txtConvertPesoToPeso.Text = moneda.GetCantidad().ToString();
                    txtConvertPesoToEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                    txtConvertPesoToDolar.Text = ((Dolar)moneda).GetCantidad().ToString();

                }

            }
        }
    }
}
