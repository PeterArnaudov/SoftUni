namespace KnightsOfHonor
{
    using System;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split();

            Action<string> printer = x => Console.WriteLine($"Sir {x}");

            foreach (var name in names)
            {
                printer(name);
            }
        }
    }
}
