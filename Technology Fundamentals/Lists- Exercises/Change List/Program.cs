using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Delete")
                {
                    for (int i = numbers.Count - 1; i >= 0; i--)
                    {
                        numbers.Remove(int.Parse(command[1]));
                    }
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}