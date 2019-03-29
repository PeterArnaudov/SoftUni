namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double modifierOne = 0;

            if (flourType.ToLower() == "white")
            {
                modifierOne = 1.5;
            }
            else if (flourType.ToLower() == "wholegrain")
            {
                modifierOne = 1.0;
            }

            double modifierTwo = 0;

            if (bakingTechnique.ToLower() == "crispy")
            {
                modifierTwo = 0.9;
            }
            else if (bakingTechnique.ToLower() == "chewy")
            {
                modifierTwo = 1.1;
            }
            else if (bakingTechnique.ToLower() == "homemade")
            {
                modifierTwo = 1.0;
            }

            return this.weight * 2 * modifierOne * modifierTwo;
        }
    }
}
