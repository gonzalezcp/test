using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class Luz
    {
        public Luz(string nombre)
        {
            _nombre = nombre;
        }
        string _nombre;
        public void LightOn()
        {
            Console.WriteLine("prediento luz {0}", _nombre);
        }
        public void LightOff()
        {
            Console.WriteLine("apagando luz {0}", _nombre);
        }
    }
}
