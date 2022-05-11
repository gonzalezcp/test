using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public class Main
    {
        public static void Run()
        {
            //cliente
            ControlRemto control = new ControlRemto("Control 1");
            ControlRemto control2 = new ControlRemto("Control 2");

            Luz luz1 = new Luz("Luz Jaridn");
            Luz luz2 = new Luz("Luz garaje");

            control.Command1 = new ConcreteCommandPrenderLuz(luz1);
            control.Command2 = new ConcreteCommandPrenderLuz(luz2);

            control2.Command1 = new ConcreteCommandApagarLuz(luz1);
            control2.Command2 = new ConcreteCommandApagarLuz(luz2);

            control.Boton1();
            control.Boton2();

            control2.Boton1();
            control2.Boton2();
        }
    }
}
