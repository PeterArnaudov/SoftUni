using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    public class Program
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            Library library = new Library();

            List<Book> books = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                books.Add(ReadBook());
            }

            library.Books = books;

            PrintBooks(library);
        }

        public static Book ReadBook()
        {
            string[] information = Console.ReadLine().Split();

            return new Book
            {
                Title = information[0],
                Author = information[1],
                Publisher = information[2],
                ReleaseDate = DateTime.ParseExact(information[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = information[4],
                Price = double.Parse(information[5])
            };
        }

        public static void PrintBooks(Library library)
        {
            var ordered = library.Books.GroupBy(x => x.Author).Select(g => new { Author = g.Key, Prices = g.Sum(s => s.Price) }).OrderByDescending(x => x.Prices).ThenBy(x => x.Author).ToList();

            foreach (var author in ordered)
            {
                Console.WriteLine($"{author.Author} -> {author.Prices:f2}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
