using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bebidas;
using ControlCantina;

namespace FrmCantina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out
           tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(rbCerveza.Checked)
            {
                Cerveza auxCerveza = new Cerveza((int)nUDCapacidad.Value, txtMarca.Text, (Botella.Tipo)cmbBotellaTipo.SelectedItem , (int)nUDContenido.Value);
                this.barra1.AgregarBotella(auxCerveza);
            }
            else
            {
                Agua auxAgua = new Agua((int)nUDCapacidad.Value, txtMarca.Text, (int)nUDContenido.Value);
                this.barra1.AgregarBotella(auxAgua);
            }
        }
    }
}
