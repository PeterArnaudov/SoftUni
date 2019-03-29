namespace SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SportCards
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, double>> cards = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string information = Console.ReadLine();

                if (information == "end")
                {
                    break;
                }
                else if (information.Contains(" - "))
                {
                    AddCard(cards, information);
                }
                else if (information.Contains("check"))
                {
                    CheckCard(cards, information);
                }
            }

            PrintCards(cards);
        }

        public static void AddCard(Dictionary<string, Dictionary<string, double>> cards, string information)
        {
            string[] informationTokens = information.Split(" - ");

            string card = informationTokens[0];
            string sport = informationTokens[1];
            double price = double.Parse(informationTokens[2]);

            if (!cards.ContainsKey(card))
            {
                cards.Add(card, new Dictionary<string, double>());
            }

            if (!cards[card].ContainsKey(sport))
            {
                cards[card].Add(sport, 0);
            }

            cards[card][sport] = price;
        }

        public static void CheckCard(Dictionary<string, Dictionary<string, double>> cards, string information)
        {
            string[] informationTokens = information.Split();

            string card = informationTokens[1];

            if (cards.ContainsKey(card))
            {
                Console.WriteLine($"{card} is available!");
            }
            else
            {
                Console.WriteLine($"{card} is not available!");
            }
        }

        public static void PrintCards(Dictionary<string, Dictionary<string, double>> cards)
        {
            foreach (var card in cards.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{card.Key}:");
                foreach (var sport in card.Value.OrderBy(s => s.Key))
                {
                    Console.WriteLine($"  -{sport.Key} - {sport.Value:f2}");
                }
            }            
        }
    }
}
