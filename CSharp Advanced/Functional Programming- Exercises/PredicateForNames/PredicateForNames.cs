namespace PredicateForNames
{
    using System;
    using System.Linq;

    public class PredicateForNames
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Action<string[]> printer = x =>
            {
                Predicate<string> filter = n => n.Length <= length;

                foreach (var name in names.Where(n => filter(n)))
                {
                    Console.WriteLine(name);
                }
            };

            printer(names);


            //simpler solution:
            //
            //Predicate<string> filter = x => x.Length <= length;
            //
            //foreach (var name in names.Where(x => filter(x)))
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
