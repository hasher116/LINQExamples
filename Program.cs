namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstListNumbers = new List<int>() // входной массив
            {
                6, 22, -67, 23, 76, 89, 35, 28
            };


            FirstExample.ListSortExample(firstListNumbers); // 1 пример
            Console.WriteLine("\n");
            FirstExample.LINQSortExample(firstListNumbers); // конец 1 примера


            SecondExample.GetEvenNumberSquared(firstListNumbers); // 2 пример
            Console.WriteLine("\n");
            SecondExample.GetEvenNumberSquaredLINQ(firstListNumbers); // конец 2 примера

            var students = new List<(string, int)>
            {
                ("Андрей", 18),
                ("Саша", 20),
                ("Маша", 19),
                ("Лена", 18),
                ("Вася", 22),
                ("Кирилл", 24),
                ("Лёша", 22),
                ("Андрей", 23),
                ("Маша", 22),
                ("Саша", 18),
                ("Аня", 19),
                ("Миша", 25)
            };

            ThirdExample.CounterAndrew(students); // 3 пример
            Console.WriteLine("\n");
            ThirdExample.CounterAndrewLINQ(students);
            Console.WriteLine("\n");
            ThirdExample.StartWithSymbolA(students);// конец 3 примера


            var shop = new Shop();

            // Добавляем книги в магазин
            shop.AddBook(new Book("J.K. Rowling", "Harry Potter and the Sorcerer's Stone", 1997));
            shop.AddBook(new Book("George Orwell", "1984", 1949));
            shop.AddBook(new Book("Isaac Asimov", "Foundation", 1951));

            // Добавляем игры в магазин
            shop.AddGame(new Game("The Witcher 3", 2015, GenreEnum.RPG));
            shop.AddGame(new Game("Tetris", 1984, GenreEnum.Strategy));
            shop.AddGame(new Game("Pac-Man", 1980, GenreEnum.Simulator));

            foreach (var item in shop)
            {
                Console.WriteLine(item);
            }
        }
    }
}
