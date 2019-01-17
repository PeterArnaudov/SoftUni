using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merging_Lists
{
    public class Program
    {
        public static void Main()
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> merged = new List<int>();

            for (int i = 0; i < Math.Min(listOne.Count(), listTwo.Count()); i++)
            {
                merged.Add(listOne[i]);
                merged.Add(listTwo[i]);
            }

            for (int i = Math.Min(listOne.Count(), listTwo.Count()); i < Math.Max(listOne.Count(), listTwo.Count()); i++)
            {
                if (listOne.Count() > listTwo.Count())
                {
                    merged.Add(listOne[i]);
                }
                else
                {
                    merged.Add(listTwo[i]);
                }
            }

            Console.WriteLine(string.Join(" ", merged));
        }
    }
}
