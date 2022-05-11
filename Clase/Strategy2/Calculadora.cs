using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Strategy2
{
    public class Calculadora
    {
        public StrategyOperacion strategyOperacion { get; set; }
        
        public int num1 { get; set; }
        public int num2 { get; set; }

        public double resolver()
        {
            return strategyOperacion.resolver(num1, num2);
        }
    }
}
