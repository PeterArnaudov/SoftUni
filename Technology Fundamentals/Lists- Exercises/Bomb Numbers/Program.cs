using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray(); //[0] = number; [1] = power

            while (numbers.Contains(bomb[0]))
            {
                int takeOut = bomb[1] * 2 + 1;
                int startIndex = numbers.IndexOf(bomb[0]) - bomb[1];

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                if (takeOut > numbers.Count - 1)
                {
                    takeOut = numbers.Count - startIndex;
                }

                numbers.RemoveRange(startIndex, takeOut);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}