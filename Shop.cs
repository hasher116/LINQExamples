using System.Collections;

namespace ConsoleApp1
{
    public class Shop : IEnumerable
    {
        public List<Book> Books { get; set; }
        public List<Game> Games { get; set; }

        public Shop()
        {
            Books = new List<Book>();
            Games = new List<Game>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddGame(Game game)
        {
            Games.Add(game); 
        }

        public IEnumerator<string> GetEnumerator()
        {
            return Books
                .OrderBy(x => x.Name)
                .Select(x => x.Name + $" {x.Year}")
                .Concat(Games
                    .OrderBy(x => x.Name)
                    .Select(x => x.Name + $"{x.Year}")).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
