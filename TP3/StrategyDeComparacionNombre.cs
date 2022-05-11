using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class StrategyDeComparacionNombre : StrategyDeComparacion
    {
        public bool SosIgual(Alumno al, Alumno al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre())==0;
        }

        public bool SosMayor(Alumno al, Alumno al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) < 0;
        }

        public bool SosMenor(Alumno al, Alumno al2)
        {
            return al.GetNombre().CompareTo(al2.GetNombre()) > 0;
        }
    }
}
