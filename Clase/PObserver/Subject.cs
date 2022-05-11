using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PObserver
{
    public interface Subject
    {
        void AddObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObserver();
    }
}
