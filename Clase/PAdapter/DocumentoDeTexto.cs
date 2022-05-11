using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    public class DocumentoDeTexto : IDocumento
    {
        public string texto;
        public string nombre;

        public string GetNombre()
        {
            return nombre;
        }

        public void MostrarVistaPrevia()
        {
            Console.WriteLine(texto);
        }
    }
}
