using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.PObsever
{
    public interface Observable
    {
        void AddObserver(Observador o);
        void RemoveObserver(Observador o);
        void NotifyObserver();
    }
}
