using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.PIterador
{
    public class IteradorDeCola : Iterador
    {
        List<Comparable> _comparable;
        int posicionActual = 0;
        public IteradorDeCola(Cola cola)
        {
            this._comparable = cola._comparables;
        }
        public object Actual()
        {
            return _comparable[posicionActual];
        }

        public bool Fin()
        {
            return _comparable.Count == posicionActual;
        }

        public void Primero()
        {
            posicionActual = 0;
        }

        public void Siguiente()
        {
            posicionActual++;
        }
    }
}
