namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Classes.Animals;
    using WildFarm.Classes.Foods;
    using WildFarm.Factories;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string[] info = Console.ReadLine().Split();

                if (info[0] == "End")
                {
                    break;
                }

                Animal animal = AnimalFactory.CreateAnimal(info);

                info = Console.ReadLine().Split();
                Food food = FoodFactory.CreateFood(info);

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.Feed(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
