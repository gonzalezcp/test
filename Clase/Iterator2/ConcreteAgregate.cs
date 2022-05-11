using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Iterator2
{
    public class ConcreteAgregate : Iterable
    {
        public List<int> lista = new List<int>();

        public void Add(int numero)
        {
            lista.Add(numero);
        }
        public Iterator CreateIterator()
        {
            return new IteradorDeListaDeInteros(this);
        }
    }
}
