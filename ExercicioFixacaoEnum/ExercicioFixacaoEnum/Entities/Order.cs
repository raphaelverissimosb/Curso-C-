using ExercicioFixacaoEnum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExercicioFixacaoEnum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime moment)
        {
            this.Moment = moment;
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total() {

            double sum = 0.0;
             
            foreach (OrderItem item in Items) {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Örder Status: " + Status);
            sb.AppendLine("Client Information :" + Client.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items) {
                Items.ToString();
            }

            sb.AppendLine("Total Price:" + Total().ToString());

            return sb.ToString();

        }
    }
}
