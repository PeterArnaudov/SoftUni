namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            DateModifier difference = new DateModifier(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(difference.Difference);
        }
    }
}
