using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PProxy
{
    public class DocumentoDeTextoProxy : IDocumento
    {
        string _nombre;
        DocumentoDeTexto docuemntoReal;
        public DocumentoDeTextoProxy(string nombre)
        {
            _nombre = nombre;
        }
        public string GetNombre()
        {
            if (docuemntoReal == null)
                return _nombre;
            else
                return docuemntoReal.GetNombre();
        }

        public void MostrarVistaPrevia()
        {
            if (docuemntoReal == null)
                docuemntoReal = new DocumentoDeTexto(_nombre);
            docuemntoReal.MostrarVistaPrevia();
        }

        public void SetNombre(string nombre)
        {
            if (docuemntoReal == null)
                _nombre = nombre;
            else
                docuemntoReal.SetNombre(nombre);
        }
    }
}
