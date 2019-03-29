namespace Animals.Animals.Cats
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {
        }

        protected override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
