using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PObserver
{
    public class Display : Observer
    {
        string _nombre;
        public Display(string nombre)
        {
            this._nombre = nombre;
        }
        public void Update(object subject)
        {
            Console.WriteLine("observador : " + _nombre + " observandor " + subject);
        }
    }
}
