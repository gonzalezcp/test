using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class ControlRemto
    {
        // invoker
        public Command Command1 { get; set; }
        public Command Command2 { get; set; }
        public ControlRemto(string nombre)
        {
            _nombre = nombre;
        }
        public string _nombre;
        public void Boton1()
        {
            Console.WriteLine("Boton1 Contro {0}", _nombre);
            Command1.Execute();
        }

        public void Boton2()
        {
            Console.WriteLine("Boton2 Contro {0}", _nombre);
            Command2.Execute();
        }
    }
}
