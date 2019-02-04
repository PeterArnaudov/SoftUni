namespace Animals
{
    using System;
    using Animals;
    using Animals.Cats;

    public static class AnimalProducer
    {
        public static Animal GetAnimal(string animalType, string name, int age, string gender = null)
        {
            if (animalType == "Dog")
            {
                return new Dog(name, age, gender);
            }
            else if (animalType == "Cat")
            {
                return new Cat(name, age, gender);
            }
            else if (animalType == "Frog")
            {
                return new Frog(name, age, gender);
            }
            else if (animalType == "Kitten")
            {
                return new Kitten(name, age);
            }
            else if (animalType == "Tomcat")
            {
                return new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
        }
    }
}
