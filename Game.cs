using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public GenreEnum GenreGame { get; set; }

        public Game(string name, int year, GenreEnum genre)
        {
            Name = name;
            Year = year;
            GenreGame = genre;
        }
    }

    public enum GenreEnum
    {
        RPG = 1,
        MMORPG = 2,
        Strategy = 3,
        Simulator = 4
    }
}
