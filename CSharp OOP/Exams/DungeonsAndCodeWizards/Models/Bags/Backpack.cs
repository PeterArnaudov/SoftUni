namespace DungeonsAndCodeWizards.Models.Bags
{
    using System;

    public class Backpack : Bag
    {
        private const int BackpackCapacity = 100;

        public Backpack() 
            : base(BackpackCapacity)
        {
        }
    }
}
