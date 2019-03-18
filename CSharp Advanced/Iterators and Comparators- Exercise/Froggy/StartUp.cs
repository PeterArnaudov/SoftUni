namespace Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
