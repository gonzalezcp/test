using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PIterador;

namespace TP3
{
    public class Cola : Coleccionable
    {
        public List<Comparable> _comparables = new List<Comparable>();
        private HashSet<Comparable> _comparables2 = new HashSet<Comparable>(); 
        public void Agregar(Comparable o)
        {
            _comparables.Add(o);
        }

        public bool Contiene(Comparable o)
        {
            return _comparables.Contains(o);
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeCola(this);
        }

        public int Cunatos()
        {
            return _comparables.Count();
        }

        public Comparable Maximo()
        {
            //Comparable maximo = _comparables[0];
            //for (int i = 0; i < _comparables.Count; i++)
            //    if (maximo.SosMayor(_comparables[i]))
            //        maximo = _comparables[i];
            //return maximo
            Comparable maximo = null;
            foreach (Comparable o in _comparables)
            { 
                if (maximo==null)
                    maximo = o;
                if (maximo.SosMayor(o))
                    maximo = o;
            }
            return maximo;
        }

        public Comparable Minimo()
        {
            //Comparable minimo = _comparables[0];
            //for (int i = 0; i < _comparables.Count; i++)
            //    if (minimo.SosMenor(_comparables[i]))
            //        minimo = _comparables[i];
            //return minimo;
            Comparable minimo = null;
            foreach (Comparable o in _comparables)
            {
                if (minimo == null)
                    minimo = o;
                if (minimo.SosMenor(o))
                    minimo = o;
            }
            return minimo;
        }
    }
}
