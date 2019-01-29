namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int GetToppingsCount()
        {
            return this.toppings.Count;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            double totalCalories = 0;

            totalCalories += this.dough.GetCalories();

            foreach (var topping in this.toppings)
            {
                totalCalories += topping.GetCalories();
            }

            return totalCalories;
        }

        public override string ToString()
        {
            return $"{this.name} - {this.GetCalories():f2} Calories.";
        }
    }
}
