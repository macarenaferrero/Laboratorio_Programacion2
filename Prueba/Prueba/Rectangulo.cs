using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Rectangulo
    {
        int x;
        int y;
        int largo;
        int alto;
        Color color;

        public Rectangulo(int x, int y, int largo, int alto, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Largo = largo;
            this.Alto = largo;
            this.Color = color;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Largo { get => largo; set => largo = value; }
        public int Alto { get => alto; set => alto = value; }
        public Color Color { get => color; set => color = value; }
    }
}
