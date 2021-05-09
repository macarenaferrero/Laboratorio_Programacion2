using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reparcial;

namespace Libreria
{
    public partial class FrmTest : Form
    {
        Vendedor laMaca;
        public FrmTest()
        {
            InitializeComponent();
            laMaca = new Vendedor("Macarena");
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnVendeer_Click(object sender, EventArgs e)
        {
            if (!(laMaca is null) && !(lstStock.SelectedItem is null))
            {
                Publicacion venta = (Publicacion)lstStock.SelectedItem;
                if (venta.HayStock && laMaca + venta)
                {
                    MessageBox.Show("Venta añadida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venta NO añadida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            if (!(laMaca is null))
            {
                rtbInforme.Text = Vendedor.InformeDeVentas(laMaca);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
