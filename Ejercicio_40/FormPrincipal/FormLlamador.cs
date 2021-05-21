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
    public partial class FormLlamador : Form
    {
        private Centralita c;

        private Centralita Centralita
        {
            get
            {
                return this.c;
            }
        }
        public FormLlamador()
        {
            InitializeComponent();
            cbFranja.Enabled = false;
        }

        public FormLlamador(Centralita centralitaFormLlamador)
            : this()
        {
            this.c = centralitaFormLlamador;
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cbFranja.Enabled = true;
                // Carga
                cbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                // Lectura
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cbFranja.SelectedValue.ToString(), out franjas);
            }
            else
            {
                cbFranja.Enabled = false;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float auxDuracion;
            float auxCosto;
            Random auxRandom = new Random();

            if (txtNroDestino.Text != null && txtNroOrigen.Text != null)
            {
                auxDuracion = auxRandom.Next(1, 51);
                if (txtNroDestino.Text.StartsWith("#"))
                {
                    try
                    {
                        Provincial auxLlamada = new Provincial(txtNroOrigen.Text, (Provincial.Franja)cbFranja.SelectedIndex, auxDuracion, txtNroDestino.Text);
                        c = c + auxLlamada;
                        MessageBox.Show("Llamada Provincial Generada con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    catch (CentralitaException epa)
                    {
                        string mensaje = epa.Message + epa.NombreClase + epa.NombreMetodo;
                        MessageBox.Show(mensaje);
                    }

                }
                else
                {
                    auxCosto = auxRandom.Next(5, 56) / 10;
                    try
                    {
                        Local auxLlamada = new Local(auxDuracion, txtNroDestino.Text, txtNroOrigen.Text, auxCosto);
                        c = c + auxLlamada;
                        MessageBox.Show("Llamada local Generada con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    catch (CentralitaException epa)
                    {
                        string mensaje = epa.Message + epa.NombreClase + epa.NombreMetodo;
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = string.Empty;
            txtNroOrigen.Text = string.Empty;
            cbFranja.SelectedIndex = -1;
            cbFranja.Enabled = false;
        }

        private void FormLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult aux = MessageBox.Show("Esta seguro de que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (aux == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
