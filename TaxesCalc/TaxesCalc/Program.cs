using System;
using System.Collections.Generic;
using System.Globalization;
using TaxesCalc.Entities;

namespace TaxesCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of the tax payers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Individual or Company? (i/c) ?");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual Income:");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.WriteLine("Health Expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual Income:");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.WriteLine("Number of Employees:");
                    int numberOfEmployes = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployes));
                }

            }

            foreach (TaxPayer tax in list)
            {
                Console.WriteLine("Name:" + tax.Name);
                Console.WriteLine(tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("**************************************");
            }

            double sum = 0.0;
            foreach (TaxPayer taxValues in list )
            {
                sum += taxValues.Tax();
            }

            Console.WriteLine("total Taxes: R$"+ sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
