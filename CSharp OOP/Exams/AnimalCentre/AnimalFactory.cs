namespace AnimalCentre
{
    using Models.Animals;
    using Models.Contracts;
    using System;

    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            if (type == "Cat")
            {
                return new Cat(name, energy, happiness, procedureTime);
            }
            else if (type == "Dog")
            {
                return new Dog(name, energy, happiness, procedureTime);
            }
            else if (type == "Lion")
            {
                return new Lion(name, energy, happiness, procedureTime);
            }
            else if (type == "Pig")
            {
                return new Pig(name, energy, happiness, procedureTime);
            }

            return null;
        }
    }
}
