using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class SalterCardsState : State
    {
        public override void Handle(StateManager sm)
        {
            DateTime date;
            DateTime date2;
            int salterIndex;

            Console.Write("Broj na salter(1-10): ");
            string sSalterIndex = Console.ReadLine();
            if (!sSalterIndex.All(char.IsDigit))
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

            Console.Write("Vreme od(primer na format 19:05): ");
            string sDate = (Console.ReadLine());
            DateTime expectedDate;
            if (!DateTime.TryParseExact(sDate, "HH:mm", new CultureInfo("en-US"),
                            DateTimeStyles.None, out expectedDate))
            {
                Console.WriteLine("Gresen format na vreme!");
                sm.PopState();
                return;
            }
            date = DateTime.ParseExact(sDate, "HH:mm", null);

            Console.Write("Vreme do(primer na format 19:05): ");
             sDate = (Console.ReadLine());
            if (!DateTime.TryParseExact(sDate, "HH:mm", new CultureInfo("en-US"),
                            DateTimeStyles.None, out expectedDate))
            {
                Console.WriteLine("Gresen format na vreme!");
                sm.PopState();
                return;
            }
            date2 = DateTime.ParseExact(sDate, "HH:mm", null);
            List<Card> karti= sm.Salteri[salterIndex].Cards.Where(c => c.Date.TimeOfDay.TotalMinutes>=date.TimeOfDay.TotalMinutes && c.Date.TimeOfDay.TotalMinutes<=date2.TimeOfDay.TotalMinutes).ToList();
            Console.WriteLine(string.Format("Salter {0} ima prodadeno {1} karti", salterIndex + 1, karti.Count));
            karti.ForEach(Console.WriteLine);
            sm.PopState();
        }
    }
}
