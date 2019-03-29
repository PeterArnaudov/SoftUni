namespace InfernoInfinity.Core.Commands
{
    using System;
    using System.Linq;
    using InfernoInfinity.CustomAttributes;
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Weapons;

    public class RevisionCommand : Command
    {
        public RevisionCommand(IRepository repository, string[] data) 
            : base(repository, data)
        {
        }

        public override void Execute()
        {
            Type weaponType = typeof(Weapon);
            var attribute = (InformationAttribute) weaponType.GetCustomAttributes(false).First();

            Console.WriteLine($"Revision: {attribute.Revision}");
        }
    }
}
