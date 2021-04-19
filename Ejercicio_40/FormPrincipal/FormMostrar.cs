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
    public partial class FormMostrar : Form
    {
        private Llamada.TipoLlamada tipoLlamada;
        private Centralita c;


        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                tipoLlamada = value;
            }
        }
        public FormMostrar()
        {
            InitializeComponent();
        }

        public FormMostrar(Centralita centralitaFormMenu) : this()
        {
            this.c = centralitaFormMenu;
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            if(tipoLlamada is Llamada.TipoLlamada.Local)
            {
                richTextBox.Text = "Local: " + c.GananciasPorLocal.ToString();
            }
            else if (tipoLlamada is Llamada.TipoLlamada.Provincial)
            {
                richTextBox.Text = "Provincial: " + c.GananciasPorProvincial.ToString();
            }
            else
            {
                richTextBox.Text = "Todas: " + c.GananciasPorTotal.ToString();
            }
        }
    }
}
