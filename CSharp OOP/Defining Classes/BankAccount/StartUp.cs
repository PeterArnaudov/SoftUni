namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Create")
                {
                    int id = int.Parse(command[1]);

                    if (!accounts.Any(x => x.Id == id))
                    {
                        accounts.Add(new BankAccount(id));
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                }
                else if (command[0] == "Deposit")
                {
                    int id = int.Parse(command[1]);
                    decimal amount = decimal.Parse(command[2]);

                    BankAccount requested = accounts.FirstOrDefault(x => x.Id == id);

                    if (requested == null)
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        requested.Deposit(amount);
                    }
                }
                else if (command[0] == "Withdraw")
                {
                    int id = int.Parse(command[1]);
                    decimal amount = decimal.Parse(command[2]);

                    BankAccount requested = accounts.FirstOrDefault(x => x.Id == id);

                    if (requested == null)
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else if (amount > requested.Balance)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        requested.Withdraw(amount);
                    }
                }
                else if (command[0] == "Print")
                {
                    int id = int.Parse(command[1]);

                    BankAccount requested = accounts.FirstOrDefault(x => x.Id == id);

                    if (requested == null)
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine(requested.ToString());
                    }
                }
                else if (command[0] == "End")
                {
                    return;
                }
            }
        }
    }
}
