namespace Animals.Animals.Cats
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
        }

        protected override string ProduceSound()
        {
            return "Meow";
        }
    }
}
