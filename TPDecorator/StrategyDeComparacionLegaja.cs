using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator
{
    public class StrategyDeComparacionLegajo : StrategyDeComparacion
    {
        public bool SosIgual(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetLegajo() == al2.GetLegajo();
        }

        public bool SosMayor(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetLegajo() < al2.GetLegajo();
        }

        public bool SosMenor(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetLegajo() > al2.GetLegajo();
        }
    }
}
