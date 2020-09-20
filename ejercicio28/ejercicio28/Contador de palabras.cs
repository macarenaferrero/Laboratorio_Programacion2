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

            Dictionary<string, int> palabras = new Dictionary<string, int>();

            string auxPalabras;
            auxPalabras = this.richTxtPalabras.Text;
            string[] variasPalabras;
            variasPalabras = auxPalabras.Split(' ');

            foreach (string palabra in variasPalabras)
            {
                if(!palabras.ContainsKey(palabra))
                {
                    palabras.Add(palabra, 1);
                }
                else
                {
                    palabras[palabra]++;
                }

            }

            //convierto diccionario a lista
            List<KeyValuePair<string, int>> listaPalabras = palabras.ToList();

            //lista a sort 
            // dict.OrderBy(x => x.Value).ToDictionary()
            listaPalabras.Sort(OrdenarPorInt);

            MessageBox.Show($"La palabra mas usada es {listaPalabras[0].Key}, {listaPalabras[0].Value} veces");
            

        }

        public static int OrdenarPorInt(KeyValuePair<string, int> palabraSiguiente, KeyValuePair<string, int> palabraActual)
        {
            int retorno = 0;
            if(palabraActual.Value > palabraSiguiente.Value)
            {
                retorno = 1;
            }
            else if(palabraActual.Value < palabraSiguiente.Value)
            {
                retorno = -1;
            }

            return retorno;
        }
    }
}
