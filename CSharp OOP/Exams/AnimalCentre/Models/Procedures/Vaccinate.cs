namespace AnimalCentre.Models.Procedures
{
    using System;
    using Models.Contracts;

    public class Vaccinate : Procedure
    {
        public Vaccinate() 
            : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Energy -= 8;
            animal.IsVaccinated = true;
        }
    }
}
