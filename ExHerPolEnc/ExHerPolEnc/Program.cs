using ExHerPolEnc.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExHerPolEnc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of the employees");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.WriteLine("Outsourced (y/n) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge:");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("*****PAYMENTS*****");

            foreach (Employee emp in list)
            {
                Console.WriteLine("Name - " + emp.Name + "R$:" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
