using System;
using System.Globalization;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de produtos :");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe nome do produto:[" + i +"]");
                string name = Console.ReadLine();
                Console.WriteLine("Informe o preco do produto:[ "+ i +"]");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Avarege price = "+ avg );

        }
    }
}
