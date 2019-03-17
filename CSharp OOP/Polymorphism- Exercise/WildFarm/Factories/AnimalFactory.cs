namespace WildFarm.Factories
{
    using System;
    using WildFarm.Classes.Animals;
    using WildFarm.Classes.Animals.Birds;
    using WildFarm.Classes.Animals.Mammals;
    using WildFarm.Classes.Animals.Mammals.Felines;

    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string[] info)
        {
            if (info[0] == "Owl")
            {
                return new Owl(info[1], double.Parse(info[2]), double.Parse(info[3]));
            }
            else if (info[0] == "Hen")
            {
                return new Hen(info[1], double.Parse(info[2]), double.Parse(info[3]));
            }
            else if (info[0] == "Mouse")
            {
                return new Mouse(info[1], double.Parse(info[2]), info[3]);
            }
            else if (info[0] == "Dog")
            {
                return new Dog(info[1], double.Parse(info[2]), info[3]);
            }
            else if (info[0] == "Cat")
            {
                return new Cat(info[1], double.Parse(info[2]), info[3], info[4]);
            }
            else if (info[0] == "Tiger")
            {
                return new Tiger(info[1], double.Parse(info[2]), info[3], info[4]);
            }
            else
            {
                throw new ArgumentException("Invalid animal type!");
            }
        }
    }
}
