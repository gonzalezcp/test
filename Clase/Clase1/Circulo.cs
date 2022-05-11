using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Clase1
{
    public class Circulo : FiguraGeometrica, Imprimible
    {
        public Circulo(int radio, string nombre) : base(nombre)
        {
            this.radio = radio;
        }
        private int _radio;

        public int radio 
        {
            get { return _radio; }

            set
            {
                //if (value < 0)
                //    throw new ArgumentOutOfRangeException();
                //else
                //    this._radio = value;
                _ = value < 0 ? throw new ArgumentOutOfRangeException() : this._radio = value;
            }
        }
        public override double GetArea()
        {
            return Math.Pow(radio, 2) * Math.PI;
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
