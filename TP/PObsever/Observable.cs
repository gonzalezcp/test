using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.PObsever
{
    public interface Observable
    {
        //Subject abstacto en el Observer
        void AddObserver(Observador o);
        void RemoveObserver(Observador o);
        void NotifyObserver();
    }
}
