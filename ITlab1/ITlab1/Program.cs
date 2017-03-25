using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class Program
    {
        public static bool running = true;
        static StateManager sm= new StateManager(new MenuState());
        static void Main(string[] args)
        {
            while (running)
            {
                sm.Request();
            }
        }
    }
}
