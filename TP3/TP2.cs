using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PIterador;

namespace TP3
{
    public class TP2
    {
        public static void Run()
        {
            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            StrategyDeComparacion estrategiaDeComparacion = new StrategyDeComparacionNombre();
            cola = LlenarColeccionableConAlumnos(cola, estrategiaDeComparacion);
            pila = LlenarColeccionableConAlumnos(pila, estrategiaDeComparacion);
            Informar(pila);
            Informar(cola);
            ImprimirElementos(cola);
            ImprimirElementos(pila);

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

        public static void RunStrategy()
        {
            Alumno al1 = new Alumno("Jose", 1, 1, 1 );
            al1.strategyDeComparacion = new StrategyDeComparacionNombre();
            Alumno al2 = new Alumno("Aldo", 2, 2, 2);
            Console.WriteLine( al1.SosMayor(al2) );
        }

        public static void RunPersonas()
        {
            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            cola = LlenarColeccionableConPersonas(cola);
            // cola = LlenarColeccionableConPersonas(cola, strategy)

            pila = LlenarColeccionableConPersonas(pila);
            Informar(pila);
            Informar(cola);
        }

        public static void RunAlumnos()
        {
            Coleccionable cola = new Cola();
            Coleccionable pila = new Pila();
            cola = LlenarColeccionableConPersonas(cola);
            // cola = LlenarColeccionableConPersonas(cola, strategy)

            pila = LlenarColeccionableConPersonas(pila);
            Informar(pila);
            Informar(cola);
            Alumno alumno = new Alumno("Alberto", 53658998, 156, 8);
            
        }

        public static Coleccionable LlenarColeccionableConNumeros(Coleccionable coleccionable)
        {
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(new Numero(random.Next(1000)));
            }
            return coleccionable;
        }

        public static Coleccionable LlenarColeccionableConPersonas(Coleccionable coleccionable)
        {
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                coleccionable.Agregar(new Persona(GetNombre(), new Random().Next(99999999)));
            }
            return coleccionable;
        }

        public static Coleccionable LlenarColeccionableConAlumnos(Coleccionable coleccionable, 
            StrategyDeComparacion estrategiaDeCompracion)
        {
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {
                Alumno al = new Alumno(GetNombre(), new Random().Next(99999999),
                    new Random().Next(100000), new Random().Next(10));
                al.strategyDeComparacion = estrategiaDeCompracion;
                coleccionable.Agregar(al);
            }
            return coleccionable;
        }

        public static void InformarNumeros(Coleccionable coleccionable)
        {
            //if (coleccionable.GetType() == typeof(Numero))
            Console.WriteLine("Cantidad de elementos de la Coleccion {0}", coleccionable.Cunatos());
            Console.WriteLine("Elementos mas grande de la Coleccion {0}", ((Numero)coleccionable.Maximo()).GetValor());
            Console.WriteLine("Elementos mas chico de la Coleccion {0}", ((Numero)coleccionable.Minimo()).GetValor());
            Console.WriteLine("Ingrese un valor");
            string numero = Console.ReadLine();
            var numoerPorTeclado = new Numero(int.Parse(numero));
            if (coleccionable.Contiene(numoerPorTeclado))
                Console.WriteLine("el numero {0} ingresado esta en la coleccion", numero);
            else
                Console.WriteLine("el numero {0} ingresado NO esta en la coleccion", numero);
        }

        public static void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("Cantidad de elementos de la Coleccion {0}", coleccionable.Cunatos());
            Console.WriteLine("Elementos mas grande de la Coleccion {0}", coleccionable.Maximo());
            Console.WriteLine("Elementos mas chico de la Coleccion {0}", coleccionable.Minimo());
        }

        public static string GetNombre()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Jose");
            nombres.Add("Roberto");
            nombres.Add("Antonio");
            nombres.Add("Martin");
            nombres.Add("Rodolfo");
            nombres.Add("Miguel");
            nombres.Add("Joaquin");
            nombres.Add("Valentin");
            nombres.Add("Ramiro");
            nombres.Add("Nahuel");
            nombres.Add("Lisandro");
            nombres.Add("Agustina");
            nombres.Add("Josefina");
            nombres.Add("Maria");
            nombres.Add("Eugenia");
            nombres.Add("Emilia");
            nombres.Add("Andrea");
            nombres.Add("Susana");
            nombres.Add("Marta");
            nombres.Add("Mirta");
            nombres.Add("Cristina");
            nombres.Add("Amalia");
            return nombres[new Random().Next(nombres.Count - 1)];
        }
    }
}
