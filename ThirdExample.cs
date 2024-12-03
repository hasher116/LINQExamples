using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ThirdExample
    {
        public static void CounterAndrew(List<(string, int)> list)
        {
            var counter = 0;
            foreach (var i in list)
            {
                if (i.Item1 == "Андрей" || i.Item2 == 18)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        public static void CounterAndrewLINQ(List<(string, int)> list)
        {
            var counter = list
                .Count(x => x.Item1 == "Андрей" || x.Item2 == 18);
            Console.WriteLine(counter);
        }

        public static void StartWithSymbolA(List<(string, int)> list)
        {
            var counter = list
                .Where(x => x.Item1.StartsWith('А'))
                .Count();
            Console.WriteLine(counter);
        }
    }
}
