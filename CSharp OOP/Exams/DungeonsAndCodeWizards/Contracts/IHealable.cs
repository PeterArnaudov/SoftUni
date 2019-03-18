namespace DungeonsAndCodeWizards.Contracts
{
    using DungeonsAndCodeWizards.Models.Characters;
    using System;

    public interface IHealable
    {
        void Heal(Character character);
    }
}
