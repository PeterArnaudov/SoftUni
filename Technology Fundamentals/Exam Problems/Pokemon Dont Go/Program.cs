using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Dont_Go
{
    public class Program
    {
        public static void Main()
        {
            List<int> pokemons = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int outputSum = 0;

            while (pokemons.Count() > 0)
            {
                int index = int.Parse(Console.ReadLine());
                bool outsideNegative = false;
                bool outsidePositive = false;

                if (index < 0)
                {
                    index = 0;
                    outsideNegative = true;
                }
                else if (index > pokemons.Count() - 1)
                {
                    index = pokemons.Count() - 1;
                    outsidePositive = true;
                }

                int removedValue = pokemons[index];
                outputSum += removedValue;
                pokemons.RemoveAt(index);

                if (outsideNegative)
                {
                    pokemons.Insert(0, pokemons[pokemons.Count() - 1]);
                }
                else if (outsidePositive)
                {
                    pokemons.Add(pokemons[0]);
                }

                for (int i = 0; i < pokemons.Count(); i++)
                {
                    if (removedValue >= pokemons[i])
                    {
                        pokemons[i] += removedValue;
                    }
                    else
                    {
                        pokemons[i] -= removedValue;
                    }
                }
            }

            Console.WriteLine(outputSum);
        }
    }
}
