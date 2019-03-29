namespace GenericCountMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericCountMethodString
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                list.Add(Console.ReadLine());
            }

            Console.WriteLine(CountOfGreaterElements<string>(list, Console.ReadLine()));
        }

        public static int CountOfGreaterElements<T>(List<T> list, T element) where T : IComparable
        {
            return list.Where(e => e.CompareTo(element) > 0).Count();
        }
    }
}
