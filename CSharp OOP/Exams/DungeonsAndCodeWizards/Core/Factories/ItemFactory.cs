namespace DungeonsAndCodeWizards.Core.Factories
{
    using DungeonsAndCodeWizards.Models.Items;
    using System;

    public static class ItemFactory
    {
        public static Item CreateItem(string itemType)
        {
            if (itemType == "HealthPotion")
            {
                return new HealthPotion();
            }
            else if (itemType == "PoisonPotion")
            {
                return new PoisonPotion();
            }
            else if (itemType == "ArmorRepairKit")
            {
                return new ArmorRepairKit();
            }
            else
            {
                throw new ArgumentException($"Invalid item {(char)34}{itemType}{(char)34}!");
            }
        }
    }
}
