using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FMBicicletas
{
    public  class Main
    {
        public static void Run()
        {
            //FMBicicleta fm;
            Console.WriteLine("1 - bicicleta mtb");
            Console.WriteLine("2 - bicleta bmx");
            string opcion = Console.ReadLine();
            //if (opcion == "1")
            //    fm = new FMBicicletaMTB();
            //else
            //    fm = new FMBicicletaBMX();
            Bicicleta bici = FMBicicleta.CrearBicicleta(opcion);


            Console.WriteLine(bici);
        }
    }
}
