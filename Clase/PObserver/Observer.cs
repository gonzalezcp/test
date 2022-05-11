using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PObserver
{
    public interface Observer
    {
        void Update(object subject);
    }
}
