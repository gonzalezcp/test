using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Iterator2
{
    public class Main
    {
        public static void Run()
        {
            ConcreteAgregate agregate = new ConcreteAgregate();
            agregate.Add(1);
            agregate.Add(2);
            agregate.Add(3);
            Iterator iter = agregate.CreateIterator();
            while (!iter.fin())
            {
                var numero = (int)iter.actual();
                Console.WriteLine(numero);
                iter.siguiente();
            }
        }
    }
}
