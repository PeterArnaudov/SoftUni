using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Factory
{
    class Program
    {
        static void Main()
        {
            int batches = int.Parse(Console.ReadLine());

            for (int i = 1; i <= batches; i++)
            {
                bool eggs = false;
                bool flour = false;
                bool sugar = false;

                while (true)
                {
                    string ingredient = Console.ReadLine();

                    if (ingredient == "eggs")
                    {
                        eggs = true;
                    }
                    else if (ingredient == "flour")
                    {
                        flour = true;
                    }
                    else if (ingredient == "sugar")
                    {
                        sugar = true;
                    }
                    else if (ingredient == "Bake!")
                    {
                        if (eggs && flour && sugar)
                        {
                            Console.WriteLine($"Baking batch number {i}..."); break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }
        }
    }
}
