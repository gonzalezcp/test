using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PCommand
{
    public interface Command
    {
        public void Execute();
        public void Undo();
    }
}
