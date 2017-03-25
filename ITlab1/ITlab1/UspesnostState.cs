using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class UspesnostState : State
    {
        public override void Handle(StateManager sm)
        {
            Console.WriteLine("Uspesnost na agencijata "+((float)sm.Salteri.Select(s=>s.Cards.Count()).Sum()/ (float)sm.NumberClients)*100+"%");
            sm.PopState();
        }
    }
}
