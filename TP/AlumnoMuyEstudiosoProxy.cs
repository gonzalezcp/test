using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PProxy;

namespace TP
{
    public class AlumnoMuyEstudiosoProxy : ALumnoProxy
    {
        private AlumnoMuyEstudiosoProxy _alumnoReal = null;

        public AlumnoMuyEstudiosoProxy(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            if (_alumnoReal == null)
            {
                _alumnoReal = new AlumnoMuyEstudiosoProxy(GetNombre(), GetDni(), GetLegajo(), GetPromedio());
                _alumnoReal.SetCalifacion(this.GetCalificacion());
            }
            return _alumnoReal.ResponderPregunta(pregunta);
        }
    }
}
