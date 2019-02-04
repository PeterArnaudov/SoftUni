namespace Telephony
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Smartphone smartphone = new Smartphone();

            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                try
                {
                    smartphone.Call(number);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var url in urls)
            {
                try
                {
                    smartphone.Browse(url);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
