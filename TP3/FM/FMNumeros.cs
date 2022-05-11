using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.FM
{
    public class FMNumeros : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            return new Numero(new Random().Next(10000));
        }

    }
}
