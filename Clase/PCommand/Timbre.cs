using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class Timbre
    {
        string _nombre;
        public Timbre(string nombre)
        {
            _nombre = nombre;
        }
        public void TocarTimbre()
        {
            Console.WriteLine("tocaron el timbre {0}", _nombre);
        }
    }
}
