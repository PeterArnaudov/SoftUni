namespace AnimalCentre.Models.Procedures
{
    using System;
    using Models.Contracts;

    public class NailTrim : Procedure
    {
        public NailTrim()
            : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= 7;
        }
    }
}
