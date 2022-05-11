using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FM
{
    public abstract class FMProfesores
    {
        //public static Profesor CrearProfesor(string opcion)
        //{
        //    FMProfesores fm = null;
        //    if (opcion == "1")
        //        fm = new FMProfesoresLocales();
        //    else
        //        fm = new FMProfesoresSuplentes();
            
        //    return fm.CrearProfesor();
        //}
        public abstract Profesor CrearProfesor();
    }
}
