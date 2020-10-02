using System;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now; //Horario atual do sistema 
            Console.WriteLine(d1);

            //Utilizando com Construtor
            DateTime d2 = new DateTime(2018,11,25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018,05,01,20,45, 03);
            Console.WriteLine(d3);
        }



    }
}
