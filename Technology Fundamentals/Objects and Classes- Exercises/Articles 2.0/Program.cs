using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public class Program
    {
        public static void Main()
        {
            List<Article> articles = new List<Article>();

            int articlesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < articlesNumber; i++)
            {
                string[] information = Console.ReadLine().Split(", ");

                articles.Add(new Article(information));
            }

            string factor = Console.ReadLine();

            if (factor == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (factor == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (factor == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            articles.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string[] information)
        {
            Title = information[0];
            Content = information[1];
            Author = information[2];
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
