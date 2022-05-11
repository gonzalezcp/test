using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Strategy1
{
    public class Main
    {
        public static void Run()
        {
            Persona p = new Persona();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("1 - castellando");
                Console.WriteLine("2 - ingles");
                Console.WriteLine("3 - frances");

                string opcion = Console.ReadLine();
                Strategy strategy;
                if (opcion == "1")
                    strategy = new StrategyCastellano();
                else if (opcion == "2")
                    strategy = new StrategyIngles();
                else
                    strategy = new StrategyFrances();
                p.strategy = strategy;
                p.Saludar();
            }

        }
    }
}
