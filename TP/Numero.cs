using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Numero : Comparable
    {
        public Numero(int v)
        {
            this.valor = v;
        }
        private int valor;
        public int GetValor()
        {
            return valor;
        }

        public bool SosIgual(Comparable o)
        {
            return this.valor == ((Numero)o).valor;
        }

        public bool SosMenor(Comparable o)
        {
            return this.valor > ((Numero)o).valor;
        }

        public bool SosMayor(Comparable o)
        {
            return this.valor < ((Numero)o).valor;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
