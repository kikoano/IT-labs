using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITlab1
{
    class AllCardsSoldState : State
    {
        public override void Handle(StateManager sm)
        {
            DateTime date;
            DateTime date2;
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
            List<Salter> dateSalters = sm.Salteri.Where(s => s.Cards.Any(c => c.Date.TimeOfDay.TotalMinutes >= date.TimeOfDay.TotalMinutes && c.Date.TimeOfDay.TotalMinutes <= date2.TimeOfDay.TotalMinutes)).ToList();
            // dateSalters.Sort((s1, s2) => s1.Index.CompareTo(s2.Index));
            foreach (Salter s in dateSalters)
            {
                Console.WriteLine("Salter " + s.Index+" ima prodadeno " + s.Cards.Count+" karti");
                s.Cards.ForEach(Console.WriteLine);
            }
            sm.PopState();

        }
    }
}
