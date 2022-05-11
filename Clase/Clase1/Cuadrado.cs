using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    internal class Cuadrado : FiguraGeometrica
    {
        public int lado;
        public Cuadrado(int lado, string nombre):base(nombre)
        {
            this.lado = lado;
        }

        public override double GetArea()
        {
            return Math.Sqrt(lado);
        }
    }
}
