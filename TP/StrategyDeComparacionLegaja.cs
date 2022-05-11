using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP
{
    //Concrete Strategy
    public class StrategyDeComparacionLegajo : StrategyDeComparacion
    {
        public bool SosIgual(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetLegajo() == al2.GetLegajo();
        }

        public bool SosMayor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetLegajo() < al2.GetLegajo();
        }

        public bool SosMenor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetLegajo() > al2.GetLegajo();
        }
    }
}
