using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalc.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }


        public Company()
        {
        }

        public Company(string name, double anulIncome, int numberOfEmployes) : base(name, anulIncome)
        {
            this.NumberOfEmployees = numberOfEmployes;
        }
        public override double Tax()
        {
            double taxValue = 0.0;

            if (NumberOfEmployees > 10)
            {
                taxValue = AnualIncome * 0.16;
            }
            else
            {
                taxValue = AnualIncome * 0.14;
            }

            return taxValue;
        }
    }
}
