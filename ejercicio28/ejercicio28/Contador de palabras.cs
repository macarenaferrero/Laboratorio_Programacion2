using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ejercicio28
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        



        private void Calcular_OnClick(object sender, EventArgs e)
        {

            Dictionary<string, int> Palabras = new Dictionary<string, int>();

            string auxPalabras;
            auxPalabras = this.richTxtPalabras.Text;
            string[] variasPalabras;
            variasPalabras = auxPalabras.Split(' ');
            int contador = 1;

            foreach (string palabra in variasPalabras)
            {
                if(!Palabras.ContainsKey(palabra))
                {
                    Palabras.Add(palabra, contador);
                }
                else
                {
                    Palabras[palabra]++;
                }
                contador = 1;
                

                MessageBox("Wd");
            }
        }
    }
}
