using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resourceType = Console.ReadLine();

                if (resourceType == "stop")
                {
                    break;
                }

                int resourceQuantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resourceType))
                {
                    resources[resourceType] += resourceQuantity;
                }
                else
                {
                    resources.Add(resourceType, resourceQuantity);
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
