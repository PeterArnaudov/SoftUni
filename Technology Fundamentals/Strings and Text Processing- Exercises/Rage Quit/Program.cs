using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Quit
{
    public class Program
    {
        public static void Main()
        {
            //regex = @"([^\d]+)([\d]{1,2})"

            string input = Console.ReadLine().ToUpper();

            List<char> outputList = new List<char>();
            List<char> currentList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (!Char.IsNumber(character)) //if the current character is not a number (no matter a single digit or not) => add it to the current part list
                {
                    currentList.Add(character);
                }

                if (Char.IsNumber(character))
                {
                    int count = 0;

                    if (i < input.Length - 1 && Char.IsNumber(input[i + 1])) //check if the number is not a sigle digit (>9)
                    {
                        string str = input.Substring(i, 2);
                        count = int.Parse(str.ToString());
                    }
                    else //in case the number is a single digit (<10)
                    {
                        count = ((int)Char.GetNumericValue(character));
                    }

                    if (count > 0) //add the current part to the result X times (where X is the number)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            outputList.AddRange(currentList);
                        }
                    }

                    currentList.Clear(); //clear the list with the current part
                }
            }

            string output = new string(outputList.ToArray()); //create the output string
            Console.WriteLine("Unique symbols used: {0}", output.Distinct().Count());
            Console.WriteLine(output);
        }
    }
}
