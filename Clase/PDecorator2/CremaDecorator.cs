using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator2
{
    public class CremaDecorator : Decorator
    {
        public CremaDecorator(Componente componente) : base(componente)
        {
        }

        public override string GetDescripcion()
        {
            return _componente.GetDescripcion() + " - crema";
        }

        public override int GetPrecio()
        {
            return _componente.GetPrecio() + 50;
        }
    }
}
