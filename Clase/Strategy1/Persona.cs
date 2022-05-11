using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Strategy1
{
    public class Persona  // Context
    {
        public Persona()
        {
            strategy = new StrategyCastellano();
        }
        public Strategy strategy { get; set; }
        public void Saludar()
        {
            strategy.Saludar();
        }
    }
}
