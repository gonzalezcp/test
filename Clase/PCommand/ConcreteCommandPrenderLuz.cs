using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class ConcreteCommandPrenderLuz : Command
    {
        Luz _luz;
        public ConcreteCommandPrenderLuz(Luz luz)
        {
            _luz = luz;
        }

        public void Execute()
        {
            _luz.LightOn();
        }

        public void Undo()
        {
            _luz.LightOff();
        }
    }
}
