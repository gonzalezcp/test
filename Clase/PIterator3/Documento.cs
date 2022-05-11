using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PIterator3
{
    public class Documento : Iterable
    {
        //Paginas[] paginas = new Paginas[10];
        //Stack<Paginas> paginas2 = new Stack<Paginas>();
        public List<Pagina> paginas = new List<Pagina>();

        public Iterador crearIterador()
        {
            return new IteradorDeDocumentos(this);
        }
    }
}
