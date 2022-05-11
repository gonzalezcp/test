using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PProxy;

namespace TP.FM
{
    public class FMAlumnosProxy : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            ALumnoProxy al = new ALumnoProxy(Helper.GetNombre(), new Random().Next(99999999), new Random().Next(999999), new Random().Next(10));
            return al;
        }

        public override Comparable CrearPorTecaldo()
        {
            Console.WriteLine("ingrese un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese un legajo");
            int legajo = Int32.Parse(Console.ReadLine());
            ALumnoProxy al = new ALumnoProxy(nombre, 1, legajo, 10);
            return al;
        }
    }
}
