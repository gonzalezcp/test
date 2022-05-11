using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    public class AdapterIMageToIDocumento : IDocumento
    {
        IImage _image;
        public AdapterIMageToIDocumento(IImage image)
        {
            this._image = image;
        }
        public string GetNombre()
        {
            return _image.GetName();
        }

        public void MostrarVistaPrevia()
        {
            _image.ShowPreview();
        }
    }
}
