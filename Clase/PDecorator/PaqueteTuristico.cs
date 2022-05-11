using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PDecorator
{
    // Componente Concreto o Corete Componet
    public class PaqueteTuristico : IPaqueteTuristico
    {
        public int _cantidadDias;
        public int _precioLugar;
        public string _lugar;
        public double Precio()
        {
            return _cantidadDias * _precioLugar;
        }

        public override string ToString()
        {
            return "_lugar: " + _lugar + ", cantidad de dias: " + _cantidadDias + ", precio total: " + Precio();
        }
    }
}