using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public abstract class FMBicicleta
    {
        public static Bicicleta CrearBicicleta(string opcion)
        {
            FMBicicleta fm = null;
            if (opcion == "1")
                fm = new FMBicicletaMTB();
            else
                fm = new FMBicicletaBMX();
            return fm.CrearBicicleta();
        }
        public abstract Bicicleta CrearBicicleta();

    }
}
