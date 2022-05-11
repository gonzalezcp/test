using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.FM
{
    public class FMAlumnos : FMComparables
    {
        public override Comparable CrearAleatoio()
        {
            Alumno al = new Alumno(Helper.GetNombre(), new Random().Next(99999999), new Random().Next(999999), new Random().Next(10));
            return al;
        }
    }
}
