using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PProxy
{
    public class DocumentoDeTexto : IDocumento
    {
        string _nombre;
        public DocumentoDeTexto(string nombre)
        {
            Console.WriteLine("Creando docuemnto de Texto....");
            Thread.Sleep(2000);
            _nombre = nombre;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void MostrarVistaPrevia()
        {
            Console.WriteLine("mostrando vista previa de documento: " + _nombre);
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
    }
}
