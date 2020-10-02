using System;
using System.Globalization;

namespace ExTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20)?preco * 0.10 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
