using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Iterator2
{
    //Agregate en Iterator
    public interface Iterable
    {
        Iterator CreateIterator();
    }
}
