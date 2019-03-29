namespace Animals
{
    using Animals;
    using Animals.Cats;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] animalInformation = Console.ReadLine().Split();

                try
                {
                    animals.Add(AnimalProducer.GetAnimal(animalType, animalInformation[0], int.Parse(animalInformation[1]), animalInformation[2]));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            animals.ForEach(a => Console.WriteLine(a));
        }
    }
}
