namespace AnimalCentre.Models
{
    using Models.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class Hotel : IHotel
    {
        private int capacity;
        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.capacity = 10;
            this.animals = new Dictionary<string, IAnimal>();
        }

        public int Capacity => this.capacity;

        public IReadOnlyDictionary<string, IAnimal> Animals => new ReadOnlyDictionary<string, IAnimal>(this.animals);

        public void Accommodate(IAnimal animal)
        {
            if (this.Capacity == 0)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            else if (this.Animals.Any(a => a.Key == animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            this.animals.Add(animal.Name, animal);
            this.capacity--;
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.Animals.Any(a => a.Key == animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            IAnimal animal = Animals[animalName];
            animal.Owner = owner;
            animal.IsAdopt = true;
            this.animals.Remove(animalName);
            this.capacity--;
        }
    }
}
