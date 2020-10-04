

namespace HerancaEPolimorfismo.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public virtual void withDraw(double amount)
        {
            Balance -= amount+ 5.00;
        }
        public void Depoist(double amount)
        {
            Balance += amount;
        }

       
    }
}
