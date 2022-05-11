using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    internal interface Colleccionable
    {
        void Agregar(IComparable o);

        IComparable Minimo();
        IComparable Maximo();
        bool Contiene(IComparable o);

    }
}
