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

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            PrintBooks(date, library);
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

        public static void PrintBooks(DateTime date, Library library)
        {
            var toPrint = library.Books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title)
                .Select(x => new { x.Title, x.ReleaseDate });

            foreach (var book in toPrint)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.Day:d2}.{book.ReleaseDate.Month:d2}.{book.ReleaseDate.Year}");
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
