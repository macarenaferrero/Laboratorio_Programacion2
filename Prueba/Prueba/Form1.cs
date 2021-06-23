using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class FrmPrincipal : Form
    {
        List<Rectangulo> listaRectangulos;
        //Coincide con la firma que quiero invocar
        private delegate void Callback();

        Thread hilo;
        Thread hilo2;


        public FrmPrincipal()
        {
            InitializeComponent();
            listaRectangulos = new List<Rectangulo>();

            listaRectangulos.Add(new Rectangulo(20, 0, 20, 20, Color.Blue));
            listaRectangulos.Add(new Rectangulo(520, 0, 20, 20, Color.Green));
            listaRectangulos.Add(new Rectangulo(280, 0, 20, 20, Color.Yellow));
            hilo = new Thread(new ParameterizedThreadStart(Mover));
            hilo = new Thread(Mover);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach (Rectangulo item in listaRectangulos)
            {
                Pen colorRojo = new Pen(item.Color);
                for (int i = 0; i < 20; i++)
                {
                    e.Graphics.DrawRectangle(colorRojo, item.X + i, item.Y + i, item.Largo - i, item.Alto - i);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!hilo.IsAlive)
            {
                hilo.Start(this.listaRectangulos[0]);
            }

            if (!hilo.IsAlive)
            {
                hilo2.Start(this.listaRectangulos[1]);
            }

        }

        private void MoverAuch()
        {
            foreach (Rectangulo item in listaRectangulos)
            {
                while (item.Y < this.Height - item.Alto - 40)
                {
                    item.Y = item.Y + 1;

                    Callback callback = new Callback(this.Refresh);
                    this.Invoke(callback);
                    Thread.Sleep(10);
                }
            }

        }

        private void Mover(object rec)
        {
            Rectangulo rectangulo = (Rectangulo)rec;
            while (rectangulo.Y < this.Height - rectangulo.Alto - 40)
            {
                rectangulo.Y = rectangulo.Y + 1;
                Callback callback = new Callback(this.Refresh);
                this.Invoke(callback);
                Thread.Sleep(10);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.hilo.Abort();
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Rectangulo item in listaRectangulos)
            {
                if(item.X < e.X && item.X + 20 > e.X)
                {
                    if(item.Y < e.Y && item.Y + 20 > e.Y)
                    {
                        if(item.Color == Color.Red)
                        {
                            this.hilo.Abort();
                            this.hilo = new Thread(this.Mover);
                        }
                        else
                        {
                            this.hilo.Abort();
                            this.hilo2 = new Thread(this.Mover);

                        }
                    }
                }
            }
        }
    }
}
