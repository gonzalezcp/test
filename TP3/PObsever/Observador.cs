using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.PObsever
{
    public interface Observador
    {
        void Update(object subject);
    }
}
