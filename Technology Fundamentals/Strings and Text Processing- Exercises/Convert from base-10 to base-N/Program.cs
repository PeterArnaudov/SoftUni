using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_base_10_to_base_N
{
    public class Program
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger baseN = input[0];
            BigInteger decNumber = input[1];

            string converted = string.Empty;

            while (decNumber > 0)
            {
                converted += decNumber % baseN;
                decNumber = decNumber / baseN;
            }

            for (int i = converted.Length - 1; i >= 0; i--)
            {
                Console.Write(converted[i]);
            }

            //Console.WriteLine(ReverseString(converted));
        }

        //public static string ReverseString(string s)
        //{
        //    char[] arr = s.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}
    }
}
