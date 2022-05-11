using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Strategy2
{
    internal class StrategyResta : StrategyOperacion
    {
        public double resolver(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
