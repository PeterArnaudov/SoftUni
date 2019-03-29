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
            string[] information = Console.ReadLine().Split(", ");

            Article article = new Article(information);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] commandLine = Console.ReadLine().Split(": ");
                string commandType = commandLine[0];
                string content = commandLine[1];

                if (commandType == "Edit")
                {
                    article.Edit(content);
                }
                else if (commandType == "ChangeAuthor")
                {
                    article.ChangeAuthor(content);
                }
                else if (commandType == "Rename")
                {
                    article.Rename(content);
                }
            }

            Console.WriteLine(article.ToString());
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
