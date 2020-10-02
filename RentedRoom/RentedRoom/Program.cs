using System;

namespace RentedRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented?");
            int room_number = int.Parse(Console.ReadLine());
            Rooms[] vect_rooms = new Rooms[room_number];

            Console.WriteLine("What is the room number that will be rented? ");
            int number = int.Parse(Console.ReadLine());


    
                if (number < room_number)
                {
                    Console.WriteLine("Type the name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Type the e-mail:");
                    string email = Console.ReadLine();
                     vect_rooms[number] = new Rooms { Name = name, Email = email };
                }
                else
                {
                    Console.WriteLine("Rooms number is unvaiable");
                }
                
        

            for (int i = 0; i < room_number; i++) {
                if (vect_rooms[i] != null)
                {
                    Console.WriteLine("Room Number: " + i);
                    Console.WriteLine("Name: " + vect_rooms[i].Name);
                    Console.WriteLine("E-mail: " + vect_rooms[i].Email);
                }
                else {
                    Console.WriteLine("Room " + i + " is available");
                }
            }



        }
    }
}
