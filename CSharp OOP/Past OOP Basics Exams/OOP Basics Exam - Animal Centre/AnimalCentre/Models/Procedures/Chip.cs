namespace AnimalCentre.Models.Procedures
{
    using System;
    using Models.Contracts;

    public class Chip : Procedure
    {
        public Chip()
            : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            animal.Happiness -= 5;
            animal.IsChipped = true;
        }
    }
}
