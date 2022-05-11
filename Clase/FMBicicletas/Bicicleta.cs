using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public abstract class Bicicleta
    {
        public Cuadro cuadro { get; set; }
        public Ruedas ruedas { get; set; }
    }
}
