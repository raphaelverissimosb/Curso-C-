using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalc.Entities
{
    abstract class TaxPayer

    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anulIncome)
        {
            this.Name = name;
            this.AnualIncome = anulIncome;
        }

        public abstract double Tax();

    }
}
