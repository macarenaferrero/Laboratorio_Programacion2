using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploClase;
using EjrmploClase;

namespace Formulario
{
    public partial class Form1 : Form
    {
        Cajero cajero;
        public Form1()
        {
            InitializeComponent();
            cajero = new Cajero();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());
            Cajero.personas.Enqueue(Persona.HardcodearPersonas());

            foreach (var item in Cajero.personas)
            {
                this.lstIngresado.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona.InformaCajero -= Archivo.Guardar;
            Persona.InformaCajero -= Serializadora.Guardar;

            //Corroboramos que no sea nulo
            if ((Persona)this.lstIngresado.SelectedItem != null)
            {
                Persona nuevaPersona = (Persona)this.lstIngresado.SelectedItem;
                nuevaPersona.InformaEstado += this.per_InformaEstado;

                Persona.InformaCajero += Archivo.Guardar;
                Persona.InformaCajero += Serializadora.Guardar;

                cajero.Cobrar(nuevaPersona, cajero);
            }
        }


        private void per_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Persona.DelegadoEstado d = new Persona.DelegadoEstado(per_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstado();
            }
        }

        private void ActualizarEstado()
        {
            this.lstAtendido.Items.Clear();
            this.lstCobrado.Items.Clear();
            this.lstIngresado.Items.Clear();

            foreach (Persona item in Cajero.personas)
            {
                switch (item.Estado)
                {
                    case Persona.EEstado.Ingresado:
                        this.lstIngresado.Items.Add(item);
                        break;
                    case Persona.EEstado.Cobrado:
                        this.lstCobrado.Items.Add(item);
                        break;
                    case Persona.EEstado.Atentido:
                        this.lstAtendido.Items.Add(item);
                        break;
                    default:
                        break;
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cajero.CerrarCajero();
        }
    }
}
