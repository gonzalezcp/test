using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public class BicicletaMTB : Bicicleta
    {
        public override string ToString()
        {
            return "Bicicleta MTB - ruedas" + ruedas.ToString() + " - " + cuadro.ToString();
        }
    }
}
