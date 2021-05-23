using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FormPrincipal
{
    public partial class FormMenu : Form
    {
        public static Centralita c;
        public FormMenu()
        {
            InitializeComponent();
            c = new Centralita("MacaPower");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FormLlamador auxLllamador = new FormLlamador(c);
            auxLllamador.Location = this.Location;
            auxLllamador.Show();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormMostrar formAux = new FormMostrar(c);
            formAux.TipoLlamada = Llamada.TipoLlamada.Todas;
            formAux.Location = this.Location;
            formAux.Show();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FormMostrar formAux = new FormMostrar(c);
            formAux.TipoLlamada = Llamada.TipoLlamada.Local;
            formAux.Location = this.Location;
            formAux.Show();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar formAux = new FormMostrar(c);
            formAux.TipoLlamada = Llamada.TipoLlamada.Provincial;
            formAux.Location = this.Location;
            formAux.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult aux = MessageBox.Show("Esta seguro de que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(aux == DialogResult.Yes)
            {
                this.Dispose();
            }

            
        }
    }
}
