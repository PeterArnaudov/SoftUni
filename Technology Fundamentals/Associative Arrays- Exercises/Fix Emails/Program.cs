using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                //solution one => checks if the email contains .uk or .us and doesn't even add it to the dictionary
                if (email.Contains(".uk") || email.Contains(".us"))
                {
                    continue;
                }

                emails.Add(name, email);

                //solution two => checks if the email ends with .uk or .us and removes it from the dictionary
                //if (email.EndsWith(".uk") || email.EndsWith(".us"))
                //{
                //    emails.Remove(name);
                //}
            }

            foreach (var user in emails)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
