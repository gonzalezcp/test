using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PProxy
{
    public class Main
    {
        public static void Run()
        {
            IDocumento doc = new DocumentoDeTextoProxy("doc1");
            Console.WriteLine(doc.GetNombre());
            doc.MostrarVistaPrevia();
            doc.SetNombre("doc2");
            Console.WriteLine(doc.GetNombre());

            //List<IDocumento> list = new List<IDocumento>();
            //for (int i = 0; i < 10; i++)
            //{
            //    IDocumento doc = new DocumentoDeTextoProxy(new Random().Next(0, 100).ToString());
            //    list.Add(doc);
            //}
            //ImprimirNombres(list);
            //// por mas que tenga un proxy va a tardar
            //Console.WriteLine("Quiere listar el contenido de los archivos");
            //string opcion = Console.ReadLine();

            //if (opcion == "y")
            //    MirarVistePrevia(list);
        }
        
        public static void ImprimirNombres(List<IDocumento> list)
        {
            //Si tengo un proxy va a andar rapido
            foreach (var item in list)
            {
                Console.WriteLine(item.GetNombre());
            }
        }

        public static void MirarVistePrevia(List<IDocumento> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.GetNombre());
                item.MostrarVistaPrevia();
            }
        }

    }
}
