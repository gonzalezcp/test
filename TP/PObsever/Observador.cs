using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.PObsever
{
    //Observer Abstracto en Observer
    public interface Observador
    {
        void Update(object subject);
    }
}
