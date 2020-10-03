using ExemploEnum1.Entities.Enums;
using ExemploEnum1.Entities;
using System;
using System.Transactions;
using System.Globalization;

namespace ExemploEnum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name:");
            string deptName = Console.ReadLine();
            
            Console.Write("Enter Worker  Data :");
            Console.Write("----------------------");

            Console.WriteLine("Name :");
            string name = Console.ReadLine();
           
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            
            Console.Write("Enter with the Base salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dpt = new Department(deptName);

            Worker worker = new Worker(name, level, baseSalary, dpt);

            Console.Write("How many contracts to this worker?");
            int contracNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contracNumber; i++) {

                Console.Write($"Enter with #{i} contract data:"); // interpolacao
                
                Console.Write("Enter with the Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour R$:");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duration (hours):");
                int duration = int.Parse(Console.ReadLine());

                //Instanciar cada elemento 

                HourContract contract = new HourContract(date, valueHour, duration);

                worker.AddContract(contract);
            
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name : " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for :" + monthAndYear + " : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            

        }
    }
}
