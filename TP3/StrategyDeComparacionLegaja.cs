using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class StrategyDeComparacionLegajo : StrategyDeComparacion
    {
        public bool SosIgual(Alumno al, Alumno al2)
        {
            return al.GetLegajo() == al2.GetLegajo();
        }

        public bool SosMayor(Alumno al, Alumno al2)
        {
            return al.GetLegajo() < al2.GetLegajo();
        }

        public bool SosMenor(Alumno al, Alumno al2)
        {
            return al.GetLegajo() > al2.GetLegajo();
        }
    }
}
