using Enumeracao1.Entities;
using Enumeracao1.Entities.Enums;
using System;

namespace Enumeracao1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //inicializacao de um enum 
            Order order1 = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order1);
            Console.WriteLine();
            
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivere");
            Console.WriteLine(os);

           
        }
    }
}