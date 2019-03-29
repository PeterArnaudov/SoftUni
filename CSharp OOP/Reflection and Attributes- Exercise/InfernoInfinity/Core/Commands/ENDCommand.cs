namespace InfernoInfinity.Core.Commands
{
    using System;
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;

    public class ENDCommand : Command
    {
        public ENDCommand(IRepository repository, string[] data) 
            : base(repository, data)
        {
        }

        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
