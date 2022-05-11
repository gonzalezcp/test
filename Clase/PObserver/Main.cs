using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PObserver
{
    public class Main
    {
        public static void Run()
        {
            Display display = new Display("Casa");
            Display display2 = new Display("Estacion de servicio");

            EstacionMeterologica varela = new EstacionMeterologica("Varela");
            varela.SetTemperatura(18);
            varela.SetHumedad(85);
            varela.SetPresion(1080);

            varela.AddObserver(display);
            varela.AddObserver(display2);
            varela.SetTemperatura(20);
            varela.SetHumedad(75);
            varela.RemoveObserver(display2);
            varela.SetHumedad(74);

            EstacionMeterologica lapata = new EstacionMeterologica("La Plata");

            Display display3 = new Display("Casa lp");
            Display display4 = new Display("Estacion de servicio lp");
            lapata.AddObserver(display3); 
            lapata.AddObserver(display4);
            varela.SetTemperatura(10);
            varela.SetHumedad(97);

        }
    }
}
