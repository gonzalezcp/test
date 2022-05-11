using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TPDecorator
{
    public interface StrategyDeComparacion
    {
        bool SosIgual(AlumnoComponet al, AlumnoComponet al2);
        bool SosMenor(AlumnoComponet al, AlumnoComponet al2);
        bool SosMayor(AlumnoComponet al, AlumnoComponet al2);
    }
}
