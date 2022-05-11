using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.FM;
using TP3.PIterador;

namespace TP3
{
    public class TP3
    {
        public static void RunFactory()
        {
            Coleccionable cola = new Cola();
            Console.WriteLine("1 - Numero");
            Console.WriteLine("2 - Personas");
            Console.WriteLine("3 - Vendedores");

            string opcion = Console.ReadLine();
            LlenarColeccionable(cola, opcion);
            Informar(cola);
            ImprimirElementos(cola);

        }

        public static void RunJornadaDeVenas()
        {
            Coleccionable cola = new Cola();
            LlenarColeccionable(cola, "3");
            Gerente gerente = new Gerente();
            
            // me registro en cada vendedor
            Iterador iter = cola.CrearIterador();
            while (!iter.Fin())
            {
                Vendedor vendedor = (Vendedor)iter.Actual();
                iter.Siguiente();
                vendedor.AddObserver(gerente);
            }
            JormadaDeVentas(cola);
            gerente.Cerrar();

        }
        public static void JormadaDeVentas(Coleccionable coleccionable)
        {
            Iterador iter = coleccionable.CrearIterador();
            while (!iter.Fin())
            {
                Vendedor vendedor = (Vendedor)iter.Actual();
                for (int i = 0; i < 20; i++)
                {
                    vendedor.Venta(new Random().Next(1, 7000));
                }
                iter.Siguiente();
            }
        }

        public static void ImprimirElementos(Coleccionable coleccionable)
        {
            Iterador iter = coleccionable.CrearIterador();
            while (!iter.Fin())
            {
                Console.WriteLine(iter.Actual());
                iter.Siguiente();
            }
        }

        public static Coleccionable LlenarColeccionable(Coleccionable coleccionable, string opcion)
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                //FMComparables fm = null;
                //if (opcion == "1")
                //    fm = new FMNumeros();
                //else
                //    fm = new FMAlumnos();
                //coleccionable.Agregar(fm.CrearAleatorio
                Comparable comparable = FMComparables.CrearAleatorio(opcion);
                coleccionable.Agregar(comparable);
            }
            return coleccionable;
        }


        public static void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad de elementos de la Coleccion {0}", coleccionable.Cunatos());
            Console.WriteLine("Elementos mas grande de la Coleccion {0}", coleccionable.Maximo());
            Console.WriteLine("Elementos mas chico de la Coleccion {0}", coleccionable.Minimo());
        }

 
    }
}
