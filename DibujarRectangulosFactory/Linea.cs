using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Linea : Figura
    {
        public int Largo { get; set; } = 100;
        public int Ancho { get; set; } = 5;
        public Linea(Color color, int coordenadaX, int coordenadaY) : base(color, coordenadaX, coordenadaY)
        {
        }
        public override void Dibujar(Graphics g)
        {
            using (Pen pen = new Pen(Color, Ancho))
            {
                g.DrawLine(pen, CoordenadaX, CoordenadaY, CoordenadaX + Largo, CoordenadaY);
            }
        }
    }
}
