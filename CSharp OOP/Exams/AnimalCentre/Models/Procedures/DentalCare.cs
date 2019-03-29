namespace AnimalCentre.Models.Procedures
{
    using System;
    using Models.Contracts;

    public class DentalCare : Procedure
    {
        public DentalCare()
            : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness += 12;
            animal.Energy += 10;
        }
    }
}
