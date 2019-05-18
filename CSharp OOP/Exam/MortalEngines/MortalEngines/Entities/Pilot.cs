namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;

    public class Pilot : IPilot
    {
        private string name;
        private List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                }

                this.name = value;
            }
        }

        public IReadOnlyCollection<IMachine> Machines
        {
            get => this.machines;
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            return this.machines.Count == 0 ?
                $"{this.name} - {this.machines.Count} machines" :
                $"{this.name} - {this.machines.Count} machines\r\n{string.Join("\r\n", this.machines)}";
        }
    }
}
