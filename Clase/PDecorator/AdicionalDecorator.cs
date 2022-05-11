using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator
{
    public abstract class AdicionalDecorator : IPaqueteTuristico
    {
        protected IPaqueteTuristico _paqueteTuristico;
        public AdicionalDecorator(IPaqueteTuristico paqueteTuristico)
        {
            _paqueteTuristico = paqueteTuristico;
        }
        public abstract double Precio();
    }
}
