using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class SavingsAccount: Account
    {
        //class constant of transactionfee
        const double TRANSACTION_FEE = 5.00;

        public double Interest { get; set; }
        //constructor
        public SavingsAccount(int number,
            string Name, double
            balance,
            double interest) : base(number, Name, balance)
        {
            Interest = interest;
        }
        //calculate deposit
        public override void Deposit(double amount)
        {
            Balance += amount;
            Balance -= TRANSACTION_FEE;
        }
       //calculate withdraw
        public override void Withdraw(double amount)
        {
            Balance += amount;
            Balance -= TRANSACTION_FEE;
        }

    }
}
