namespace DungeonsAndCodeWizards.Models.Bags
{
    using DungeonsAndCodeWizards.Models.Items;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Bag
    {
        private int capacity = 100;
        List<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity
        {
            get => this.capacity;

            private set => this.capacity = value;
        }

        public int Load
        {
            get => this.items.Sum(i => i.Weight);
        }

        public IReadOnlyCollection<Item> Items
        {
            get => this.items;
        }

        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.Load == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            Item item = items.FirstOrDefault(i => i.GetType().Name == name);

            if (item == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            
            this.items.Remove(item);
            return item;
        }
    }
}
