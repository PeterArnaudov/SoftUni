using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Store
{
    class Program
    {
        static void Main()
        {
            // Programming Basics Online Exam - 10 and 11 March 2018
            // 13:37 - 13:45 <8 min>``````````````````````
            // 100/100

            double priceCPU = double.Parse(Console.ReadLine());
            double priceGPU = double.Parse(Console.ReadLine());
            double priceRAM = double.Parse(Console.ReadLine());
            int countRAM = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double discountedCPU = priceCPU * (1 - discount);
            double discountedGPU = priceGPU * (1 - discount);

            double totalMoney = discountedCPU + discountedGPU + priceRAM * countRAM;
            double leva = totalMoney * 1.57;
            Console.WriteLine($"Money needed - {leva:f2} leva.");
        }
    }
}
