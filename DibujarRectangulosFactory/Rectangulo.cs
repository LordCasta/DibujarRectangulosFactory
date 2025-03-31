using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class Rectangulo : Figura
    {
        public int Ancho { get; set; } = 100;
        public int Alto { get; set; } = 50;
        private static int contador = 0;
        public static int Contador => contador;

        public Rectangulo(Color color, int coordenadaX, int coordenadaY) : base(color, coordenadaX, coordenadaY)
        {
            contador++;
        }

        public override void Dibujar(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, CoordenadaX, CoordenadaY, Ancho, Alto);
            }
        }
    }
}
