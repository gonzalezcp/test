using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class ConcreteComnadTocarTimbre : Command
    {
        Timbre _timbre;
        public ConcreteComnadTocarTimbre(Timbre timbre)
        {
            _timbre = timbre;
        }

        public void Execute()
        {
            _timbre.TocarTimbre();
        }

        public void Undo()
        {
            Console.WriteLine("ya fue tocaste no hay vuelta para atras");
        }
    }
}
