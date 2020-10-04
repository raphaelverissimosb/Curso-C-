using ExPriceTag.Entities;
using System;
using System.Collections.Generic;

namespace ExPriceTag
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Common , Used or Imported ?(c/u/i)");
                char c = char.Parse(Console.ReadLine());

                if (c == 'c')
                {

                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price");
                    double price = double.Parse(Console.ReadLine());

                    list.Add(new Product(name, price));

                }
                else if (c == 'u')
                {

                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price:");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Manufature Date:(dd/MM/yyyy)");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufactureDate));

                }
                else if (c == 'i')
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price:");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs Fee:");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine("Sorry Try Again!!!");
                }



            }

            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
