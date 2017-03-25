using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class MenuState : State
    {
        private void Options()
        {
            Console.WriteLine("1.Usluzi go klientot");
            Console.WriteLine("2.Prodadeni karti na salterot");
            Console.WriteLine("3.Vkupen promet na salterot");
            Console.WriteLine("4.Site prodadeni karti na agencijata");
            Console.WriteLine("5.Vkupen promet na agencijara");
            Console.WriteLine("6.Uspesnost na agencijata");
            Console.WriteLine("7.Exit");
        }

        public override void Handle(StateManager sm)
        {
            Options();
            Input(sm);
        }
        private void Input(StateManager sm)
        {
            string key =Console.ReadLine();
            if (key == "1")
            {
                sm.AddState(new AddState());
            }
            else if (key == "2")
            {
                sm.AddState(new SalterCardsState());
            }
            else if (key == "3")
            {
                sm.AddState(new SalterPrometState());
            }
            else if (key == "4")
            {
                sm.AddState(new AllCardsSoldState());
            }
            else if (key == "5")
            {
                sm.AddState(new PrometState());
            }
            else if (key == "6")
            {
                sm.AddState(new UspesnostState());
            }
            else if (key == "7")
                Program.running = false;

        }
    }

}
