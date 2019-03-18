namespace DungeonsAndCodeWizards.Contracts
{
    using DungeonsAndCodeWizards.Models.Characters;
    using System;

    public interface IAttackable
    {
        void Attack(Character character);
    }
}
