using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator2
{
    public abstract class Decorator : Componente
    {
        protected Componente _componente;
        public Decorator(Componente componente)
        {
            this._componente = componente;
        }
        public abstract string GetDescripcion();

        public abstract int GetPrecio();
    }
}
