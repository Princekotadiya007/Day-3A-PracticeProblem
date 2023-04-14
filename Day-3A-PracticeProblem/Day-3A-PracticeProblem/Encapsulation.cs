using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_PracticeProblem
{
    internal class Encapsulation
    {
        private string accountNumber;
        private decimal balance;

        public Encapsulation(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
