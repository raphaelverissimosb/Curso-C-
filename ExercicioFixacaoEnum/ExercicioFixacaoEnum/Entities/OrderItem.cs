using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoEnum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set;}

        public OrderItem()
        {
            
        }
        public OrderItem(int quantity, double price, Product product) {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name + ", R$" + Price.ToString("F2", CultureInfo.InvariantCulture)
            + "Qunatity:" + Quantity + " Subtotal  $:" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);    
            
        }


    }
}
