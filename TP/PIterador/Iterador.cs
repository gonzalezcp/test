using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.PIterador
{
    //Iterator en Iterator
    public interface Iterador
    {
        void Primero();
        void Siguiente();
        object Actual();
        bool Fin();
    }
}
