using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator2
{
    public class Infusion : Componente
    {
        public int precio;
        public string nombre;
        public int GetPrecio() { return precio; }
        public string GetDescripcion()
        {
            return nombre;
        }
    }
}
