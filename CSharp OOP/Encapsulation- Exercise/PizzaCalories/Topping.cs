namespace PizzaCalories
{
    using System;

    public class Topping
    {
        private string type;
        private double weight;
        
        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double modifier = 0;

            if (this.type.ToLower() == "meat")
            {
                modifier = 1.2;
            }
            else if (this.type.ToLower() == "veggies")
            {
                modifier = 0.8;
            }
            else if (this.type.ToLower() == "cheese")
            {
                modifier = 1.1;
            }
            else if (this.type.ToLower() == "sauce")
            {
                modifier = 0.9;
            }

            return this.weight * 2 * modifier;
        }
    }
}
