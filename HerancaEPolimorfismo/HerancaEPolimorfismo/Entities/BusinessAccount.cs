using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
        : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }


        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Call to your Bank Manager! 11 9999-523");
            }
        }

    }
}
