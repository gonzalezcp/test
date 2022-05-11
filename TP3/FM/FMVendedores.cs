using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.FM
{
    public class FMVendedores : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            Vendedor vendedor = new Vendedor(Helper.GetNombre(), new Random().Next(99999999), new Random().Next(80000, 200000));
            return vendedor;
        }
    }
}
