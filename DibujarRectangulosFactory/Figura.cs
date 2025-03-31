using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public abstract class Figura
    {
        public Color Color { get; set; }
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }

        public Figura(Color color, int coordenadaX, int coordenadaY)
        {
            Color = color;
            CoordenadaX = coordenadaX;
            CoordenadaY = coordenadaY;
        }

        public abstract void Dibujar(Graphics g);

    }
}
