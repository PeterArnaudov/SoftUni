using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Program
    {
        public static void Main()
        {
            List<int> personOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> personTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {

                if (personOne.Count == 0 || personTwo.Count == 0)
                {
                    break;
                }

                if (personOne[0] == personTwo[0])
                {
                    personOne.RemoveAt(0);
                    personTwo.RemoveAt(0);
                }
                else if (personOne[0] > personTwo[0])
                {
                    personOne.Add(personOne[0]);
                    personOne.Add(personTwo[0]);
                    personOne.RemoveAt(0);
                    personTwo.RemoveAt(0);
                }
                else if (personTwo[0] > personOne[0])
                {
                    personTwo.Add(personTwo[0]);
                    personTwo.Add(personOne[0]);
                    personOne.RemoveAt(0);
                    personTwo.RemoveAt(0);
                }
            }

            if (personOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {personTwo.Sum()}");
            }
            else if (personTwo.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {personOne.Sum()}");
            }
        }
    }
}
