using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TPDecorator2
{
    public interface StrategyDeComparacion
    // Stategy de patron stategy
    {
        bool SosIgual(AlumnoComponet al, AlumnoComponet al2);
        bool SosMenor(AlumnoComponet al, AlumnoComponet al2);
        bool SosMayor(AlumnoComponet al, AlumnoComponet al2);
    }
}
