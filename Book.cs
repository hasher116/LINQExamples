using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Book(string author, string name, int year)
        {
            Author = author;
            Name = name;
            Year = year;
        }
    }
}
