using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExPriceTag.Entities
{
    class ImportedProduct : Product

    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            this.CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
             return Name + " - R$ " 
             + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
             + "Customs Fee R$ "+ CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }

        public double TotalPrice() {

            return Price + CustomsFee;

        }

    }
}
