using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PProxy
{
    public interface IDocumento
    {
        void SetNombre(string nombre);
        string GetNombre();
        void MostrarVistaPrevia();


    }
}
