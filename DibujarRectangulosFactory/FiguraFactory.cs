using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class FiguraFactory
    {
        public static Figura CrearFigura(string tipo, Color color, int x, int y)
        {
            switch (tipo)
            {
                case "Rectángulo":
                    return new Rectangulo(color, x, y);
                case "Círculo":
                    return new Circulo(color, x, y);
                case "Línea":
                    return new Linea(color, x, y);
                case "Triángulo":
                    return new Triangulo(color, x, y);
                default:
                    throw new ArgumentException("Tipo de figura no reconocido.");
            }
        }
    }
}
