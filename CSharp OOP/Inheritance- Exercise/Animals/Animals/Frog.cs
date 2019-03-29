namespace Animals.Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        protected override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
