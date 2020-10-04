

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace HerancaEPolimorfismo.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void withDraw(double amount)
        {
            base.withDraw(amount);
            Balance -= 2.0;
        }

    }
}
