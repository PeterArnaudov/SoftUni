namespace Telephony
{
    using System;
    using System.Linq;
    using Telephony.Interfaces;

    public class Smartphone : ICallable, IBrowsable
    {
        public void Call(string number)
        {
            if (number.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }

            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            Console.WriteLine($"Browsing: {url}!");
        }
    }
}
