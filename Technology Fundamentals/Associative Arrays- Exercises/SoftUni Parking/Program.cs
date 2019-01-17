using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Parking
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> registrations = new Dictionary<string, string>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] registration = Console.ReadLine().Split();

                string command = registration[0];
                string user = registration[1];

                if (command == "register")
                {
                    string plateNumber = registration[2];

                    if (!registrations.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                        registrations.Add(user, plateNumber);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!registrations.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        registrations.Remove(user);
                    }
                }
            }

            foreach (var user in registrations)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
