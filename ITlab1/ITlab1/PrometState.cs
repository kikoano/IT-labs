using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class PrometState : State
    {
        public override void Handle(StateManager sm)
        {
            Console.WriteLine("Vkupen promet na agencijata "+sm.Salteri.Select(s=>s.Promet).Sum());
            sm.PopState();
        }
    }
}
