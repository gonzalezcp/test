using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public  class Helper
    {
        public static string GetNombre()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Jose");
            nombres.Add("Roberto");
            nombres.Add("Antonio");
            nombres.Add("Martin");
            nombres.Add("Rodolfo");
            nombres.Add("Miguel");
            nombres.Add("Joaquin");
            nombres.Add("Valentin");
            nombres.Add("Ramiro");
            nombres.Add("Nahuel");
            nombres.Add("Lisandro");
            nombres.Add("Agustina");
            nombres.Add("Josefina");
            nombres.Add("Maria");
            nombres.Add("Eugenia");
            nombres.Add("Emilia");
            nombres.Add("Andrea");
            nombres.Add("Susana");
            nombres.Add("Marta");
            nombres.Add("Mirta");
            nombres.Add("Cristina");
            nombres.Add("Amalia");
            return nombres[new Random().Next(nombres.Count - 1)];
        }
    }
}
