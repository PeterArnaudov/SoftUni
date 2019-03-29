using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    public class Program
    {
        public static void Main()
        {
            CheckPasswordValidity(Console.ReadLine());
        }

        public static void CheckPasswordValidity(string password)
        {
            bool isOnlyOfLettersAndDigits = true;
            int digitsCount = 0;

            for (int i = 0; i < password.Length; i++)
            {
                isOnlyOfLettersAndDigits = (char.IsLetterOrDigit(password[i]));

                if (!isOnlyOfLettersAndDigits)
                { break; }
            }

            for (int i = 0; i < password.Length; i++)
            {
                bool isDigit = (char.IsDigit(password[i]));                
                
                if (isDigit)
                {
                    digitsCount++;
                }

                isDigit = false;
            }

            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyOfLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitsCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (password.Length >= 6 && password.Length <= 10 && isOnlyOfLettersAndDigits && digitsCount >= 2)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
