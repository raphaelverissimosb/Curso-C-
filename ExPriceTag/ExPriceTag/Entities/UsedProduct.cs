using System;
using System.Collections.Generic;
using System.Text;

namespace ExPriceTag.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name +" (Used) R$ - "+ Price + "(Manufacture Date:"+ manufactureDate +")" ;
        }



    }
}

