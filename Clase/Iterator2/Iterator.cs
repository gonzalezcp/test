using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Iterator2
{
    public interface Iterator
    {
        //bool MoveNext();
        //object Current();
        //void Reset();

        void primero();
        void siguiente();
        bool fin();
        object actual();
    }
}
