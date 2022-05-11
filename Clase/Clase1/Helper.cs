using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    internal class Helper
    {
        public static int CalcularPerimetro(Circulo circulo)
        {
            return 0;
        }
        public static int CalcularPerimetro(Cuadrado cuadrado)
        {
            //thread 1
            var parte = cuadrado.lado;  // parte = 5
            //tread 2 
            parte = cuadrado.lado;  // parte = 10
            //thread 1
            return parte * 4;
        }
    }
}
