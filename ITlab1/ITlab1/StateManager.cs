using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class StateManager
    {
        public List<Salter> Salteri {get;}= new List<Salter>();
        public int NumberClients{get; set;}=0;
        private Stack<State> states = new Stack<State>();


        private void CreateSalters()
        {
            for (int i = 0; i < 10; i++)
                Salteri.Add(new Salter(i+1));
        }

        public StateManager(State state)
        {
            CreateSalters();
            states.Push(state);
        }
        public void Request()
        {
            states.Peek().Handle(this);
        }
        public void AddState(State state)
        {
            Console.Clear();
            states.Push(state);
        }
        public void PopState()
        {
            Console.WriteLine("Pritisni bilo koe kopce za da prodolziz!");
            Console.ReadKey();
            states.Pop();
            Console.Clear();
        }
    }
}
