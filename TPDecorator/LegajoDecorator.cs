using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDecorator
{
    public class LegajoDecorator : AlumnoDecorator
    {
        public LegajoDecorator(AlumnoComponet alumnoCompomponet) : base(alumnoCompomponet)
        {
        }

        public override string MostrarCalificación()
        {
            return GetNombre() + " (" + GetLegajo() + ") " + GetCalificacion();
        }
    }
}
