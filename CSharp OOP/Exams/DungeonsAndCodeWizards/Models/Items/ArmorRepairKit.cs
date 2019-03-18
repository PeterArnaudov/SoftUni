namespace DungeonsAndCodeWizards.Models.Items
{
    using System;
    using DungeonsAndCodeWizards.Models.Characters;

    public class ArmorRepairKit : Item
    {
        private const int ArmorRepaitKitWeight = 10;

        public ArmorRepairKit() 
            : base(ArmorRepaitKitWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Armor = character.BaseArmor;
        }
    }
}
