namespace GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericCountMethodDouble
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(CountOfGreaterElements<double>(list, double.Parse(Console.ReadLine())));
        }

        public static int CountOfGreaterElements<T>(List<T> list, T element) where T : IComparable
        {
            return list.Where(e => e.CompareTo(element) > 0).Count();
        }
    }
}
