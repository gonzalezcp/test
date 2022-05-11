using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public interface StrategyDeComparacion
    {
        bool SosIgual(Alumno al, Alumno al2);
        bool SosMenor(Alumno al, Alumno al2);
        bool SosMayor(Alumno al, Alumno al2);
    }
}
