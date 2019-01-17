using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Change_Alert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshhold = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double prices = double.Parse(Console.ReadLine());

                double percentChange = Percent(last, prices);
                bool isSignificantDifference = eitherTrueOrFalse(percentChange, significanceThreshhold);
                string message = Get(prices, last, percentChange, isSignificantDifference, significanceThreshhold);

                Console.WriteLine(message);

                last = prices;
            }
        }

        private static string Get(double price, double last, double difference, bool eitherTrueOrFalse, double significanceThreshhold)
        {
            string to = "";

            if (difference == 0)
                to = string.Format("NO CHANGE: {0}", price);
            else if (!eitherTrueOrFalse)
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference * 100); 
            else if (eitherTrueOrFalse && (difference > 0))
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference * 100);
            else if (eitherTrueOrFalse && (difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference * 100);
            return to;
        }

        private static bool eitherTrueOrFalse(double significanceThreshhold, double isDiff)
        {
            if (Math.Abs(significanceThreshhold) >= isDiff)
                return true;
            return false;
        }

        private static double Percent(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}
