namespace CountUppercaseWords
{
    using System;
    using System.Linq;

    public class CountUppercaseWords
    {
        public static void Main()
        {
            Func<string, bool> checker = x => char.IsUpper(x[0]);

            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(checker).ToArray();

            Action<string> print = word => Console.WriteLine(word);

            foreach (var word in words)
            {
                print(word);
            }
        }
    }
}
