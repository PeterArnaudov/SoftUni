namespace AnimalCentre.Models.Animals
{
    using Models.Contracts;
    using System;

    public abstract class Animal : IAnimal
    {
        private int happiness;
        private int energy;
        private int procedureTime;
        private string owner;
        private bool isAdopt;
        private bool isChipped;
        private bool isVaccinated;

        public Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = "Centre";
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public string Name { get; private set; }

        public int Happiness
        {
            get => this.happiness;

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }

                this.happiness = value;
            }
        }

        public int Energy
        {
            get => this.energy;

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }

                this.energy = value;
            }
        }

        public int ProcedureTime
        {
            get => this.procedureTime;

            set => this.procedureTime = value;
        }

        public string Owner
        {
            get => this.owner;

            set => this.owner = value;
        }

        public bool IsAdopt
        {
            get => this.isAdopt;

            set => this.isAdopt = value;
        }

        public bool IsChipped
        {
            get => this.isChipped;

            set => this.isChipped = value;
        }

        public bool IsVaccinated
        {
            get => this.isVaccinated;

            set => this.isVaccinated = value;
        }

        public abstract override string ToString();
    }
}
