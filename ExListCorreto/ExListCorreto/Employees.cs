using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExListCorreto
{
    class Employees
    {

        public string Name { get; set;}
        public double Salary { get; set;}
        public int Id { get; set; }

        public Employees(string name, double salary, int id) {
            this.Name = name;
            this.Salary = salary;
            this.Id = id;
        }

        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100;
        }


        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture) + "," + Id;
        }
    }
}
