using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.PObsever;

namespace TP3
{
    public class Gerente : Observador
    {
        public List<Vendedor> mejores = new List<Vendedor>();
        //public List<Vendedor> vendedores = new List<Vendedor>();

        public void Cerrar()
        {
            Console.WriteLine("estos son los mejores vendedores");
            foreach (Vendedor vendedor in mejores)
            {
                Console.WriteLine(vendedor);
            }
        }

        public void Update(object subject)
        {
            int valorUltimeVenta = ((Vendedor)subject).ultimaVenta;
            Venta(valorUltimeVenta, (Vendedor)subject);
        }

        public void Venta(int monto, Vendedor vendedor)
        {
            if (monto >= 5000)
            {
                if (!mejores.Contains(vendedor))
                {
                    mejores.Add(vendedor);
                }
                vendedor.AumentaBonus();
            }
        }
    }
}
