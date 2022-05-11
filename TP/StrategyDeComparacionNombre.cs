using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP
{
    public class StrategyDeComparacionNombre : StrategyDeComparacion
    {
        public bool SosIgual(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre())==0;
        }

        public bool SosMayor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) < 0;
        }

        public bool SosMenor(AlumnoComponent al, AlumnoComponent al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) > 0;
        }
    }
}
