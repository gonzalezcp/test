using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public class FMBicicletaBMX : FMBicicleta
    {
        public override Bicicleta CrearBicicleta()
        {
            Bicicleta bici = new BicicletaBMX();
            bici.cuadro = new CuadroBMX();
            bici.ruedas = new Ruedas20();
            return bici;
        }
    }
}
