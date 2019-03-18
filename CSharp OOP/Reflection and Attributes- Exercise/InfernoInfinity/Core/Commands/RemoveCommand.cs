namespace InfernoInfinity.Core.Commands
{
    using InfernoInfinity.Data;
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Weapons;
    using System;

    public class RemoveCommand : Command
    {
        public RemoveCommand(IRepository repository, string[] data) 
            : base(repository, data)
        {
        }

        public override void Execute()
        {
            string weaponName = this.Data[1];
            int socketIndex = int.Parse(this.Data[2]);

            IWeapon weapon = this.Repository.Weapons.Find(w => w.Name == weaponName);
            weapon.RemoveGem(socketIndex);
        }
    }
}
