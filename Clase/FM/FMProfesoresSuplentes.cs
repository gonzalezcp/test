using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.FM
{
    public class FMProfesoresSuplentes : FMProfesores
    {
        public override Profesor CrearProfesor()
        {
            return new ProfesorSuplente();
        }
    }
}
