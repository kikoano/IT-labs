using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class Card
    {
        private string name;
        private string surName;
        private int years;
        private string destination;
        public DateTime Date { get; }
        public int Price { get; }
        public Card(string name,string surName, int years,string destination, DateTime date,int price)
        {
            this.name = name;
            this.surName = surName;
            this.years = years;
            this.destination = destination;
            Date = date;
            Price = price;
        }
        public override string ToString()
        {
            return String.Join(" ",name,surName, "godini: "+years.ToString(),"destinacija do "+destination,"cena: "+Price,"data: "+Date.ToString());
        }
    }
}
