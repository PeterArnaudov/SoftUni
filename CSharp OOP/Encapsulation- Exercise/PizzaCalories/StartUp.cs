namespace PizzaCalories
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split();

                string[] doughInfo = Console.ReadLine().Split();
                Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));

                Pizza pizza = new Pizza(pizzaName[1], dough);

                while (true)
                {
                    string[] toppingInfo = Console.ReadLine().Split();

                    if (toppingInfo[0] == "END")
                    {
                        break;
                    }

                    Topping topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
