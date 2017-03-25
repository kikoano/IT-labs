using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    abstract class State
    {
        public abstract void Handle(StateManager sm);
    }
}
