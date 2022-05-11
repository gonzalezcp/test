using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator2
{
    public class Main
    {
        public static void Run()
        {
            Componente infusion = new Infusion { precio = 100, nombre = "cafe" };
            infusion = new CremaDecorator(infusion);
            infusion = new ChocolateDecorator(infusion);
            Console.WriteLine(infusion.GetDescripcion());
            Console.WriteLine("precio: " + infusion.GetPrecio());
        }
    }
}
