using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Iterator2
{
    public class IteradorDeListaDeInteros : Iterator
    {
        List<int> _listaNumeros;
        int posicionActual = 0;
        public IteradorDeListaDeInteros(ConcreteAgregate concreteAgregate)
        {
            _listaNumeros = concreteAgregate.lista;
        }
        public object actual()
        {
            return _listaNumeros[posicionActual];
        }

        public bool fin()
        {
            return _listaNumeros.Count == posicionActual;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }
    }
}
