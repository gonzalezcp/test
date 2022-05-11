using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.PDecorator
{
    public class LegajoDecorator : AlumnoDecorator
    {
        public LegajoDecorator(AlumnoComponent alumnoCompomponet) : base(alumnoCompomponet)
        {
        }

        public override string MostrarCalificación()
        {
            return GetNombre() + " (" + GetLegajo() + ") " + GetCalificacion();
        }
    }
}
