using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(ReadMessage().Message);
            }

        }

        public static AdvertisementMessage ReadMessage()
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int phraseIndex = random.Next(0, phrases.Length);
            int eventIndex = random.Next(0, events.Length);
            int authorIndex = random.Next(0, authors.Length);
            int cityIndex = random.Next(0, cities.Length);

            return new AdvertisementMessage
            {
                Message = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}"
            };
        }
    }

    public class AdvertisementMessage
    {
        public string Message { get; set; }
    }
}
