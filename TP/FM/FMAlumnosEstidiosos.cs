using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.FM
{
    public class FMAlumnosEstudioso : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            Alumno al = new AlumnoMuyEstudioso(Helper.GetNombre(), new Random().Next(99999999), new Random().Next(999999), new Random().Next(10));
            return al;
        }

        public override Comparable CrearPorTecaldo()
        {
            throw new NotImplementedException();
        }
    }
}
