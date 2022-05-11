using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PDecorator;

namespace TP
{
    //Stategy
    public interface StrategyDeComparacion
    {
        bool SosIgual(AlumnoComponent al, AlumnoComponent al2);
        bool SosMenor(AlumnoComponent al, AlumnoComponent al2);
        bool SosMayor(AlumnoComponent al, AlumnoComponent al2);
    }
}
