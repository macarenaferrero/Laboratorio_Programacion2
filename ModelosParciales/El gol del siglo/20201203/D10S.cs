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
using Audio;

namespace _20201203
{
    public partial class D10S : Form
    {
        private Pic estado;
        private GolDelSiglo golDelSiglo;
        DAO db;

        public D10S()
        {
            InitializeComponent();
            //Inicializar
            this.golDelSiglo = new GolDelSiglo();
            //Asocio el metodo al manejador
            Relato.Avanzar += MostrarGrafico;

            db = new DAO();
        }

        private void MostrarGrafico()
        {

            if (this.InvokeRequired)
            {
                //El delegado recibe como parametro el metodo manejador
                AvanceRelato delegado = new AvanceRelato(MostrarGrafico);
                this.Invoke(delegado);
                
            }
            else
            {

                switch (estado)
                {
                    case Pic.SePrepara:
                        this.picFondo.Visible = false;
                        
                        break;
                    case Pic.LaTieneMaradona:
                        pic1.Visible = true;
                        break;
                    case Pic.ArrancaConLaPelota:
                        pic1.Visible = false;
                        pic2.Visible = true;
                        break;
                    case Pic.DejaElTendal:
                        pic2.Visible = false;
                        pic3.Visible = true;
                        break;
                    case Pic.VaATocarPara:
                        pic3.Visible = false;
                        pic4.Visible = true;
                        break;
                    case Pic.Gooool:
                        pic4.Visible = false;
                        pic5.Visible = true;
                        break;
                    case Pic.Festeja:
                        pic5.Visible = false;
                        this.picFondo.Visible = true;
                        this.picFondo.Visible = true;
                        estado--;
                        break;
                }
                estado++;
            }
        }

        private void btnGolDelSiglo_Click(object sender, EventArgs e)
        {
            try
            {
                this.golDelSiglo.IniciarJugada();
                this.db.Guardar("Se disfruto del gol" + DateTime.Now.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void D10S_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.golDelSiglo.CerrarApp();
        }

        private void btnLlerSP_Click(object sender, EventArgs e)
        {

        }
    }
}
