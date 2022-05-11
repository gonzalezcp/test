using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FM
{
    public class Main
    {
        public static void Run()
        {
            FMProfesores fm;
            Console.WriteLine("1 - profesor local");
            Console.WriteLine("2 - profesor Suplente");
            string opcion = Console.ReadLine();
            if (opcion == "1")
                fm = new FMProfesoresLocales();
            else 
                fm = new FMProfesoresSuplentes();
            UsarFabrica(fm);
        }

        public static void UsarFabrica(FMProfesores fm)
        {
            Console.WriteLine(fm.CrearProfesor().GetNombre());
        }
    }
}
