using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PIterator
{
    public class Main
    {

        public static void Run()
        {
            //IEnumerable Agregate
            //HashSet ConcreteAgregate
            //IEnumerator<int> Iterator

            HashSet<int> conjunto = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                conjunto.Add(new Random().Next(50));
            }
            ImpresoraDeIEnumerable(conjunto);


            List<int> lista = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(new Random().Next(50));
            }
            ImpresoraDeIEnumerable(lista);
        }

        public static void ImpresoraDeIEnumerable(IEnumerable<int> enumerable)
        {
            IEnumerator<int> iter = enumerable.GetEnumerator();
            while (iter.MoveNext())
            {
                int id = (int)iter.Current;
                Console.WriteLine(id);
            }
        }
    }
}
