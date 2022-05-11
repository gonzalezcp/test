using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Strategy2
{
    public class Main
    {
        public static void Run()
        {
            Calculadora calc = new Calculadora 
            { 
                num1 = 2, 
                num2 = 5, 
                strategyOperacion = new StrategySuma() 
            };

            Console.WriteLine("el resultado de la operacion es: {0}",calc.resolver());
            calc.strategyOperacion = new StrategyResta();
            Console.WriteLine("el resultado de la operacion es: {0}", calc.resolver());
        }
    }
}
