namespace InfernoInfinity.Core
{
    using InfernoInfinity.Core.Commands;
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using System;

    public static class CommandInterpreter
    {
        public static void Interprete(IRepository repository, string[] data)
        {
            string commandType = data[0] + "Command";
                        
            Type type = Type.GetType("InfernoInfinity.Core.Commands." + commandType);
            IExecutable command = (IExecutable)Activator.CreateInstance(type, new object[] { repository, data });
            command.Execute();
        }
    }
}
