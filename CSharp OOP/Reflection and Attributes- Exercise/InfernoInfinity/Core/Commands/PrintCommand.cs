namespace InfernoInfinity.Core.Commands
{
    using System;
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Weapons;

    public class PrintCommand : Command
    {
        public PrintCommand(IRepository repository, string[] data) 
            : base(repository, data)
        {
        }

        public override void Execute()
        {
            string weaponName = this.Data[1];
            IWeapon weapon = this.Repository.Weapons.Find(w => w.Name == weaponName);
            Console.WriteLine(weapon);
        }
    }
}
