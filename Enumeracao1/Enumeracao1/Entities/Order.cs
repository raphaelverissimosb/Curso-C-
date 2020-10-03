using System;
using Enumeracao1.Entities.Enums;
//Importar as bibliotecas como se faz em java 

namespace Enumeracao1.Entities
{
    class Order
    {
        // prop tab tab para o atahlo dos getters and setters
        public int Id { get; set; }
        public DateTime Moment { get; set; }
     
        public OrderStatus Status{ get; set; }
        //declaro o tipo enum com os getters and setter ccomo em qualquer outro coplemento da classe 


        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }

    }
}
