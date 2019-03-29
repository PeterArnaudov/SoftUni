namespace WildFarm.Classes.Foods
{
    using System;

    public abstract class Food
    {
        private int quantity;

        public Food(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity => this.quantity;
    }
}
