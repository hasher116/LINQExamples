using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FirstExample
    {
        public static void ListSortExample(List<int> list)
        {
            list.Sort();
            list.Reverse();

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
        }

        public static void LINQSortExample(List<int> list)
        {
            list
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
