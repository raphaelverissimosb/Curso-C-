using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalc.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anulIncome, double healthExpenditures) : base(name, anulIncome)
        {
            this.HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double taxValue = 0.0;
            if (HealthExpenditures > 0)
            {
                if (AnualIncome < 20000.00)
                {
                    taxValue = (AnualIncome * 0.15) - (HealthExpenditures / 0.5);
                }
                else
                {
                    taxValue = (AnualIncome * 0.25) - (HealthExpenditures / 0.5);
                }

            }
            else
            {
                if (AnualIncome > 20000.00)
                {
                    taxValue = (AnualIncome * 0.15);
                }
                else
                {
                    taxValue = (AnualIncome * 0.25);
                }

            }



            return taxValue;
        }
    }
}
