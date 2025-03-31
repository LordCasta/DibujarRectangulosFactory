using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarRectangulosFactory
{
    public class FiguraFactory
    {
        public static Figura CrearRectangulo(Color color, int x, int y)
        {
            return new Rectangulo(color, x, y);
        }
    }
}
