namespace InfernoInfinity
{
    using InfernoInfinity.Core;
    using InfernoInfinity.Core.Commands;
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //change some classes with interfaces, i.e. Command => IExecutable
            IRepository repository = new Repository();
            Engine.Run(repository);
        }
    }
}
