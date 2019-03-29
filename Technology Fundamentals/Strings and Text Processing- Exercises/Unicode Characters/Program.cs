using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var result = input.Select(x => string.Format("u{0:x4}", Convert.ToUInt16(x))).ToList();

            Console.WriteLine($"\\{string.Join("\\", result)}");
        }
    }
}
