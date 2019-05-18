namespace MortalEngines.IO
{
    using MortalEngines.IO.Contracts;
    using System;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
