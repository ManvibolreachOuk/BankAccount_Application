using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    abstract class Account
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }
        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }
        //abstract methods
        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

    }
}
