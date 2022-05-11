using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    public abstract class FiguraGeometrica : IComparable<FiguraGeometrica>
    {
        public string nombre;
        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }

        public int CompareTo(FiguraGeometrica? other)
        {
            if (this.GetArea() > other.GetArea())
                return -1;
            if (this.GetArea() < other.GetArea())
               return 1;
            return 0;
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return "nombre de la figura: " + nombre + " area de la figura: " + GetArea();
        }
    }
}
