using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public class FMBicicletaMTB : FMBicicleta
    {
        public override Bicicleta CrearBicicleta()
        {
            Bicicleta bici = new BicicletaMTB();
            bici.cuadro = new CuadroMTB();
            bici.ruedas = new Ruedas26();
            return bici;
        }
    }
}
