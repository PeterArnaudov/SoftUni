using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    public class Program
    {
        public static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            ////^[a-zA-Z0-9-_]{3,16}

            //string pattern = @"^[a-zA-Z0-9-_]{3,16}"; //^[\w_]{3,16}
            //Regex regex = new Regex(pattern);

            //foreach (var username in usernames)
            //{
            //    bool valid = regex.IsMatch(username) && username.Length >= 3 && username.Length <= 16;

            //    if (valid)
            //    {
            //        Console.WriteLine(username);
            //    }
            //}

            foreach (var username in usernames)
            {
                bool valid = false;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    valid = true;
                }
                else
                {
                    continue;
                }

                foreach (var character in username)
                {
                    if (character == '-' || character == '_' || char.IsLetterOrDigit(character))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
