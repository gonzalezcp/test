using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.FM
{
    public abstract class FMComparables
    {
        //metodo fabrica 1
        public abstract Comparable CrearAleatoio();
        //metodo fabrica 2
        public abstract Comparable CrearPorTecaldo();

        // opcional
        public static Comparable CrearAleatorio(string opcion)
        {
            //FMComparables fm = null;
            //if (opcion == "1")
            //    fm = new FMNumeros();
            //else if (opcion == "2")
            //    fm = new FMAlumnos();
            //else if (opcion == "3")
            //    fm = new FMVendedores();
            //else if (opcion == "4")
            //    fm = new FMAlumnosEstudioso();
            return GetFMOpcion(opcion).CrearAleatoio();
        }

        
        public static Comparable CrearPorTecaldo(string opcion)
        {
            return GetFMOpcion(opcion).CrearPorTecaldo();
        }


        private static FMComparables GetFMOpcion(string opcion)
        {
            FMComparables fm = null;
            if (opcion == "1")
                fm = new FMNumeros();
            else if (opcion == "2")
                fm = new FMAlumnos();
            else if (opcion == "3")
                fm = new FMVendedores();
            else if (opcion == "4")
                fm = new FMAlumnosEstudioso();
            else if (opcion == "5")
                fm = new FMAlumnosProxy();
            return fm;
        }
    }
}
