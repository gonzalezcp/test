using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PIterator3
{
    public class Main
    {
        public static void Run()
        {
            Documento doc = new Documento();
            doc.paginas.Add(new Pagina { numero = 1, texto = "texto pagina 1" });
            doc.paginas.Add(new Pagina { numero = 2, texto = "texto pagina 2" });
            doc.paginas.Add(new Pagina { numero = 3, texto = "texto pagina 3" });

            Iterador iter = doc.crearIterador();

            while (!iter.Fin())
            {
                Pagina pagina = (Pagina)iter.Actual();
                Console.WriteLine("texto de la pagina: " + pagina.texto);
                iter.Siguiente();
            }
        }
    }
}
