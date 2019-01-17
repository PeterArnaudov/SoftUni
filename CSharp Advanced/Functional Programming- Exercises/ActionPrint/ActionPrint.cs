namespace ActionPrint
{
    using System;

    public class ActionPrint
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split();

            Action<string> printer = x => Console.WriteLine(x);

            foreach (var name in names)
            {
                printer(name);
            }
        }
    }
}
