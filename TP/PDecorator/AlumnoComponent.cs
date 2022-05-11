using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.PDecorator
{
    public  interface AlumnoComponent : Comparable
    {
        //Componete en el patron Decorator
        //Subject en el Proxy
        public string GetNombre();
        public int GetDni();
        public string MostrarCalificación();
        public void SetCalifacion(int valor);
        public int GetCalificacion();
        public int ResponderPregunta(int pregunta);

        public bool SosIgual(Comparable o);

        public bool SosMenor(Comparable o);

        public bool SosMayor(Comparable o);

        public int GetLegajo();

        public int GetPromedio();

        public string ToString();
    }
}
