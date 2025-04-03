using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Circulo : Figura
    {
        public int Radio { get; set; } = 25;

        public Circulo(Color color, int coordenadaX, int coordenadaY) : base(color, coordenadaX, coordenadaY)
        {
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, CoordenadaX - Radio, CoordenadaY - Radio, Radio * 2, Radio * 2);
            }
        }
    }
}
