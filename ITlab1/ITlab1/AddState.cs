using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class AddState : State
    {
        private string[] availableDestinations = { "Rim", "London", "Tokio", "Sofija", "Istambul", "Toronto", "Majami", "Zagreb", "Belgrad", "Moskva" };
        public override void Handle(StateManager sm)
        {
            string name;
            string surName;
            int years;
            string destination;
            int salterIndex;

            Console.Write("Ime: ");
            name = Console.ReadLine();
            Console.Write("Prezime: ");
            surName = Console.ReadLine();
            Console.Write("Godini: ");
            string sYears = Console.ReadLine();
            if (!sYears.All(char.IsDigit))
            {
                Console.WriteLine("Nevaliden broj na godini");
                sm.PopState();
                return;
            }
            years = int.Parse(sYears);
            Console.Write("Destinacija: ");
            destination = Console.ReadLine();
            Console.Write("Salter broj(1-10): ");
            string sSalterIndex= Console.ReadLine();
            if(!sSalterIndex.All(char.IsDigit))
            {
                Console.WriteLine("Nevaliden broj na salter");
                sm.PopState();
                return;
            }
            salterIndex = int.Parse(sSalterIndex) -1;
            if (salterIndex < 0 || salterIndex >= 10)
            {
                Console.WriteLine("Nevaliden broj na salter");
                sm.PopState();
                return;
            }
            sm.NumberClients++;
            if (availableDestinations.Contains(destination))
            {
                int price= destination.Length * 1000; ;
                Card card = new Card(name, surName, years, destination, DateTime.Now, price);
                sm.Salteri[salterIndex].Cards.Add(card);
                Console.WriteLine(string.Format("Prodadena karta na {0}",card));
                sm.Salteri[salterIndex].Promet += price;
            }
            else
                Console.WriteLine(string.Format("Nepostoi destinacija do {0}",destination));
            sm.PopState();
        }
    }
}
