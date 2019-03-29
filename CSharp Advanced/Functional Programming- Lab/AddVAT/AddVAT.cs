namespace AddVAT
{
    using System;
    using System.Linq;

    public class AddVAT
    {
        public static void Main()
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            Action<double> vat = price => Console.WriteLine($"{price *= 1.2:f2}");

            foreach (var price in prices)
            {
                vat(price);
            }
        }
    }
}
