using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PIterator3
{
    public class IteradorDeDocumentos : Iterador
    {
        int posicionActual = 0;
        List<Pagina> pagias;
        public IteradorDeDocumentos(Documento doc)
        {
            pagias = doc.paginas;
        }
        public object Actual()
        {
            return pagias[posicionActual];
        }

        public bool Fin()
        {
            return pagias.Count == posicionActual;
        }

        public void Primero()
        {
            posicionActual = 0;
        }

        public void Siguiente()
        {
            posicionActual++;
        }
    }
}
