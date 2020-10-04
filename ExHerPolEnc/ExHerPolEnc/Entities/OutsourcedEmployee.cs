﻿using ExHerPolEnc.Entities;

namespace ExHerPolEnc.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }


        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours,  valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;

        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge *1.10);
        }
    }
}
