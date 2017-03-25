using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class Salter
    {
        public int Promet { get; set; } = 0;
        public int Index { get; }
        public List<Card> Cards { get; set; } = new List<Card>();
        public Salter(int index)
        {
            Index = index;
        }
    }
}
