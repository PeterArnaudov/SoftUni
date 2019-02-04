namespace MordorsCruelPlan
{
    using MordorsCruelPlan.Factories;
    using MordorsCruelPlan.Factories.Foods;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Wizard wizard = new Wizard();

            Food[] foods = Console.ReadLine().Split().Select(f => FoodFactory.GetFood(f)).ToArray();
            wizard.Eat(foods);

            Console.WriteLine(wizard);
        }
    }
}
