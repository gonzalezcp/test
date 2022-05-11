using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator
{
    public interface Comparable
    {
        bool SosIgual(Comparable o);
        bool SosMenor(Comparable o);
        bool SosMayor(Comparable o);
    }
}
