using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator2
{
    public class ChocolateDecorator : Decorator
    {
        public ChocolateDecorator(Componente componente) : base(componente)
        {
        }

        public override string GetDescripcion()
        {
            return _componente.GetDescripcion() + " - chocolate";
        }

        public override int GetPrecio()
        {
            return _componente.GetPrecio() + 30;
        }
    }
}
