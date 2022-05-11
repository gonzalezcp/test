using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator2
{
    public class LegajoDecorator : AlumnoDecorator
    {
        // Concrete Decorator en Decorator
        public LegajoDecorator(AlumnoComponet alumnoCompomponet) : base(alumnoCompomponet)
        {
        }

        public override string MostrarCalificación()
        {
            return GetNombre() + " (" + GetLegajo() + ") " + GetCalificacion();
        }
    }
}
