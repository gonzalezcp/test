using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    // Target
    public interface IDocumento
    {
        string GetNombre();
        void MostrarVistaPrevia();
    }
}
