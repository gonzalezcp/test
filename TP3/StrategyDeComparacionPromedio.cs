using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class StrategyDeComparacionPromedio : StrategyDeComparacion
    {
        public bool SosIgual(Alumno al, Alumno al2)
        {
            return al.GetPromedio() == al2.GetPromedio();
        }

        public bool SosMayor(Alumno al, Alumno al2)
        {
            return al.GetPromedio() < al2.GetPromedio();
        }

        public bool SosMenor(Alumno al, Alumno al2)
        {
            return al.GetPromedio() > al2.GetPromedio();
        }
    }
}
