namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccount
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public BankAccount(int id)
        {
            Id = id;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {            
            return $"Account ID{Id}, balance {Balance:f2}";
        }
    }
}
