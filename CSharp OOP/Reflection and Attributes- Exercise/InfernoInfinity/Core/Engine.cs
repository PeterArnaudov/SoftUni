namespace InfernoInfinity.Core
{
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using System;

    public static class Engine
    {
        public static void Run(IRepository repository)
        {
            while (true)
            {
                string[] data = Console.ReadLine().Split(';');
                CommandInterpreter.Interprete(repository, data);
            }
        }
    }
}
