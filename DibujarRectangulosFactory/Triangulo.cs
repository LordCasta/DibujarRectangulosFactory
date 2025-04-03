using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Triangulo : Figura
    {
        public int Base { get; set; } = 100;
        public int Altura { get; set; } = 50;
        public Triangulo(Color color, int coordenadaX, int coordenadaY) : base(color, coordenadaX, coordenadaY)
        {
        }
        public override void Dibujar(Graphics g)
        {
            Point[] puntos = new Point[]
            {
                new Point(CoordenadaX, CoordenadaY),
                new Point(CoordenadaX + Base / 2, CoordenadaY - Altura),
                new Point(CoordenadaX + Base, CoordenadaY)
            };
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillPolygon(brush, puntos);
            }
        }
    }
}
