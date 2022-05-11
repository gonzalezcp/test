using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP
{
    public class StrategyDeComparacionPromedio : StrategyDeComparacion
    {
        public bool SosIgual(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetPromedio() == al2.GetPromedio();
        }

        public bool SosMayor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetPromedio() < al2.GetPromedio();
        }

        public bool SosMenor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetPromedio() > al2.GetPromedio();
        }
    }
}
