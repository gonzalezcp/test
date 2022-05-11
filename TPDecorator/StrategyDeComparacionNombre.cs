using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPDecorator;

namespace TPDecorator
{
    public class StrategyDeComparacionNombre : StrategyDeComparacion
    {
        public bool SosIgual(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre())==0;
        }

        public bool SosMayor(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) < 0;
        }

        public bool SosMenor(AlumnoComponet al, AlumnoComponet al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) > 0;
        }
    }
}
