using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.FM
{
    public abstract class FMComparables
    {
        public static Comparable CrearAleatorio(string opcion)
        {
            FMComparables fm = null;
            if (opcion == "1")
                fm = new FMNumeros();
            else if (opcion == "2")
                fm = new FMAlumnos();
            else if (opcion == "3")
                fm = new FMVendedores();

            return fm.CrearAleatoio();
        }

        public abstract Comparable CrearAleatoio();

    }
}
