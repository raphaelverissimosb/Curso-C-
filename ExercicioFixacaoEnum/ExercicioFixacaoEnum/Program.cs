using ExercicioFixacaoEnum.Entities;
using ExercicioFixacaoEnum.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioFixacaoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter Client Data:");
            Console.WriteLine("**************************************");


            Console.WriteLine(" Enter the client name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the client e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter his or her Birth Date:(dd/MM/yyyy)");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);


            Console.WriteLine(" Charging Order data!");
            DateTime orderData = DateTime.Now;


            Console.WriteLine("Define the status of order:(Pending_Paymment/Processing/Shipped/Delivered)");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order1 = new Order(orderData, status, client);


            Console.WriteLine("How many items to this order:?");
            int orderItem = int.Parse(Console.ReadLine());

            for (int i = 1;i <= orderItem; i++) 
            {

                Console.WriteLine($"Item {i}");

                Console.WriteLine($"Product name #{i}");
                string productName  = Console.ReadLine();

                Console.WriteLine($"Product price #{i}");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine($"Enter the quantity #{i}");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem2 = new OrderItem(quant, price, product);

                order1.AddItem(orderItem2);
            }

            Console.WriteLine();
            Console.WriteLine("************Summary Order************");
            Console.WriteLine(order1);
        }
    }
}
