using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {

                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
      
                default:
                    Console.WriteLine("Dia da semana invalido!");
                    break;
                
            }


        }
    }
}
