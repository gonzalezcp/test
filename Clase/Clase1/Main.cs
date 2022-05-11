using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    internal class Main
    {
        public static void Run()
        {
            FiguraGeometrica figura = null;
            Console.WriteLine("1 - Circulo");
            Console.WriteLine("2 - Cuadrado");
            string opcion = Console.ReadLine();
            if (opcion == "1")
                figura = new Circulo(10, "Circulo");
            else
                figura = new Cuadrado(5, "Cuadrado");


            Console.WriteLine(figura);
            List<FiguraGeometrica> figuraGeometricas = new List<FiguraGeometrica>();
            figuraGeometricas.Add(figura);
            figuraGeometricas.Add(new Circulo(3, "Circulo2"));

            Circulo ciculonuevo = new Circulo(3, "Circulo3");
            ciculonuevo.radio = -3;

            int numero = 1;
            int numero2 = 2;
            String nombre = "Jose";
            String nombre2 = "Carlos";
            Console.WriteLine("numero > que numero2 2 {0}", numero > numero2);
            figuraGeometricas.Sort();
            Stack<FiguraGeometrica> stack = new Stack<FiguraGeometrica>();
            Queue<FiguraGeometrica> queue = new Queue<FiguraGeometrica>();
        }
    }
}
