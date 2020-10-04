using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ExPriceTag.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //Constructors
        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string PriceTag() {
            return Name + "R$ -" +Price;
        }


    }
}
