using ExemploStringBuilder.Entities;
using System;

namespace ExemploStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder manipula textos 
            Coment coment1 = new Coment("Have a nice trip");
            Coment coment2 = new Coment("Wow That's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travalling to New Zealand",
                "I am going to visit this wonderful country",
                12);

            p1.AddComent(coment1);
            p1.AddComent(coment2);

            Coment coment3 = new Coment("Good night");
            Coment coment4 = new Coment("May the force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 2:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComent(coment3);
            p2.AddComent(coment4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            
        }
    }
}
