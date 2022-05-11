using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator
{
    public class Main
    {
        public static void Run()
        {
            IPaqueteTuristico paquete =  new PaqueteTuristico { _cantidadDias = 5, _lugar = "Buzios", _precioLugar = 15000};
            Console.WriteLine("precio del paquete sin vuelo " + paquete.Precio());
            paquete = new VueloDecorator(paquete);
            Console.WriteLine("precio del paquete CON vuelo ida " + paquete.Precio());
            paquete = new VueloDecorator(paquete);
            Console.WriteLine("precio del paquete CON vuelo vuelta " + paquete.Precio());
            paquete = new AlquierAutoDecorator(paquete);
            Console.WriteLine("precio del paquete con Alquier de auto " + paquete.Precio());
        }
    }
}

// Paquete <-- Vuelo <-- Vuelo <-- Alquier de auto
