using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.FM
{
    public class FMNumeros : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            return new Numero(new Random().Next(10000));
        }

        public override Comparable CrearPorTecaldo()
        {
            throw new NotImplementedException();
        }
    }
}
