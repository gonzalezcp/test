using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class ConcreteCommandApagarLuz : Command
    {
        Luz _luz;
        public ConcreteCommandApagarLuz(Luz luz)
        {
            _luz = luz;
        }

        public void Execute()
        {
            _luz.LightOff();
        }

        public void Undo()
        {
            _luz.LightOn();
        }
    }
}
