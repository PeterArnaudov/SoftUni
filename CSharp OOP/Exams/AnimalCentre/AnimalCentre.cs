namespace AnimalCentre
{
    using Models.Procedures;
    using Models;
    using Models.Contracts;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class AnimalCentre
    {
        private IHotel hotel;
        private IProcedure chipProcedure = new Chip();
        private IProcedure vaccinateProcedure = new Vaccinate();
        private IProcedure fitnessProcedure = new Fitness();
        private IProcedure playProcedure = new Play();
        private IProcedure dentalCareProcedure = new DentalCare();
        private IProcedure nailTrimProcedure = new NailTrim();
        private Dictionary<string, List<IAnimal>> adopted = new Dictionary<string, List<IAnimal>>();

        public AnimalCentre()
        {
            this.hotel = new Hotel();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(type, name, energy, happiness, procedureTime);

            this.hotel.Accommodate(animal);

            return $"Animal {name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {
                chipProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} had chip procedure";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string Vaccinate(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {                
                vaccinateProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} had vaccination procedure";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string Fitness(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {
                fitnessProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} had fitness procedure";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string Play(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {
                playProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} was playing for {procedureTime} hours";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string DentalCare(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {
                dentalCareProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} had dental care procedure";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string NailTrim(string name, int procedureTime)
        {
            if (IsAnimalExisting(name))
            {
                nailTrimProcedure.DoService(this.hotel.Animals[name], procedureTime);

                return $"{name} had nail trim procedure";
            }
            else
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string Adopt(string animalName, string owner)
        {
            if (IsAnimalExisting(animalName))
            {
                IAnimal animal = this.hotel.Animals[animalName];
                this.hotel.Adopt(animalName, owner);
                
                if (!this.adopted.ContainsKey(owner))
                {
                    this.adopted.Add(owner, new List<IAnimal>());
                }

                this.adopted[owner].Add(animal);
                
                if (animal.IsChipped)
                {
                    return $"{owner} adopted animal with chip";
                }
                else
                {
                    return $"{owner} adopted animal without chip";
                }
            }
            else
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
        }

        public string History(string type)
        {
            if (type == "Chip")
            {
                return chipProcedure.History();
            }
            else if (type == "DentalCare")
            {
                return dentalCareProcedure.History();
            }
            else if (type == "Fitness")
            {
                return fitnessProcedure.History();
            }
            else if (type == "NailTrim")
            {
                return nailTrimProcedure.History();
            }
            else if (type == "Play")
            {
                return playProcedure.History();
            }
            else if (type == "Vaccinate")
            {
                return vaccinateProcedure.History();
            }

            return null;
        }

        public string GetAdoptedAnimals()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var owner in this.adopted.OrderBy(x => x.Key))
            {
                sb.AppendLine($"--Owner: {owner.Key}");
                sb.AppendLine($"    - Adopted animals: {string.Join(" ", owner.Value.Select(a => a.Name))}");
            }

            return sb.ToString().TrimEnd();
        }

        private bool IsAnimalExisting(string animalName)
        {
            return this.hotel.Animals.Any(a => a.Key == animalName);
        }
    }
}
