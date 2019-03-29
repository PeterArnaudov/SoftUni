namespace AnimalCentre.Models.Procedures
{
    using System;
    using Models.Contracts;

    public class Fitness : Procedure
    {
        public Fitness()
            : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= 3;
            animal.Energy += 10;
        }
    }
}
