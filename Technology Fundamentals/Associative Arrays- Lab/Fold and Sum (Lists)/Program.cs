using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum__Lists_
{
    public class Program
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int halfNumbers = input.Count() / 2;

            List<int> rowTwo = input.Skip(halfNumbers / 2).Take(halfNumbers).ToList();
            List<int> rowOneLeft = input.Take(halfNumbers / 2).ToList();
            List<int> rowOneRight = input.Skip(halfNumbers / 2 + halfNumbers).Take(halfNumbers / 2).ToList();

            rowOneLeft.Reverse();
            rowOneRight.Reverse();

            List<int> rowOne = rowOneLeft.Concat(rowOneRight).ToList();

            List<int> Summed = rowOne.Select((x, index) => x + rowTwo[index]).ToList();

            Console.WriteLine(string.Join(" ", Summed));
        }
    }
}
