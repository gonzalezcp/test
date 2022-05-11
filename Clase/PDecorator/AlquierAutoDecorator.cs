using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator
{
    public class AlquierAutoDecorator : AdicionalDecorator
    {
        public AlquierAutoDecorator(IPaqueteTuristico paqueteTuristico) : base(paqueteTuristico) { }
        public override double Precio()
        {
            return this._paqueteTuristico.Precio() + 35000;
        }
    }
}
