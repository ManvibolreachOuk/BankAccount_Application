using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    class CheckingAccount: Account
    {
        //class constant of transactionfee
        const double TRANSACTION_FEE = 4.00;
        public double Limit { get; set; }
        //constructor
        public CheckingAccount(int number,
            string name,
            double balance,
            double limit) : base(number, name, balance)
        {
            Limit = limit;
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
