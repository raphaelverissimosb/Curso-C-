using ExemploEnum1.Entities.Enums;
using Microsoft.VisualBasic;
using System.Collections.Generic;  // Import de Listas 
using System.ComponentModel;

namespace ExemploEnum1.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Composicao de Objetos

        //Devemos instanciar a Lista para garantir que ela nao seja null
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // relacao um trabalhador para VARIOS contratos 

        public Worker() { 
            
        }

        //Nunca incluir Listas em um construtor- so recebe parametros normais e nao para muitos
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) 
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts) {

                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            
            }


            return sum;
        }
    }
}
