using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteConta cliente1 = new ClienteConta();

            cliente1.Nome = "Raphael Verissimo";
            cliente1.NumeroConta = 1234;
            cliente1.DepositoInicial = 200;

            Console.WriteLine(cliente1);


        }
    }
}
