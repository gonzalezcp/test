using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    public class Main
    {
        public static void Run()
        {
            List<IDocumento> list = new List<IDocumento>();
            list.Add(new DocumentoDeTexto { nombre = "doc1", texto = "texto1" });
            list.Add(new DocumentoDeTexto { nombre = "doc2", texto = "texto2" });
            list.Add(new DocumentoDeTexto { nombre = "doc3", texto = "texto3" });

            IImage imagen = new Image { name = "imagen de algo", imageEncode64 ="imagen de perro"};
            IDocumento imageDisfrasadaDeDocuemento = new AdapterIMageToIDocumento(imagen);
            list.Add(imageDisfrasadaDeDocuemento);

            foreach (IDocumento documento in list)
            {
                documento.MostrarVistaPrevia();
            }
        }
    }
}
