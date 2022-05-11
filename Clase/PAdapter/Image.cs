using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    public class Image : IImage
    {
        public string name { get; set; }
        public string imageEncode64 { get; set; }
        public string GetName()
        {
            return name;
        }

        public void ShowPreview()
        {
            Console.WriteLine(imageEncode64);
        }
    }
}
