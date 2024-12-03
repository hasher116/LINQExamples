using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SecondExample
    {
        public static void GetEvenNumberSquared(List<int> list)
        {
            var newList = new List<int>();
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    newList.Add((int)Math.Pow(i, 2));
                }
            }

            foreach (int i in newList)
            {
                Console.WriteLine(i);
            }
        }

        public static void GetEvenNumberSquaredLINQ(List<int> list)
        {
            list
                .Where(x => x % 2 == 0)
                .Select(x => Math.Pow(x, 2))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
