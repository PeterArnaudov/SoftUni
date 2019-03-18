namespace DungeonsAndCodeWizards.Models.Bags
{
    using System;

    public class Satchel : Bag
    {
        private const int SatchelCapacity = 20;

        public Satchel() 
            : base(SatchelCapacity)
        {
        }
    }
}
