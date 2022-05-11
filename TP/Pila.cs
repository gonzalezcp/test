using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PIterador;

namespace TP
{
    public class Pila : Coleccionable
    {
        private List<Comparable> _comparables = new List<Comparable>();
        public void Agregar(Comparable o)
        {
            _comparables.Add(o);
        }

        public bool Contiene(Comparable o)
        {
            bool esta = false;
            foreach (Comparable comparable in _comparables)
            {
                if (comparable.SosIgual(o))
                    esta = true;
                if (esta)
                    break;                
            }
            return esta;
        }

        public Iterador CrearIterador()
        {
            throw new NotImplementedException();
        }

        public int Cunatos()
        {
            return _comparables.Count();
        }

        public Comparable Maximo()
        {
            Comparable maximo = _comparables[0];
            for (int i = 0; i < _comparables.Count; i++)
                if (maximo.SosMayor(_comparables[i]))
                    maximo = _comparables[i];
            return maximo;
        }

        public Comparable Minimo()
        {
            Comparable minimo = _comparables[0];
            for (int i = 0; i < _comparables.Count; i++)
                if (minimo.SosMenor(_comparables[i]))
                    minimo = _comparables[i];
            return minimo;
        }
    }
}
