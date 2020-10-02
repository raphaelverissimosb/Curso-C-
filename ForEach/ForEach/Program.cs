using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Raphael", "Noely", "Mark" };

            foreach (string obj in vect) {
                Console.WriteLine("----------------------");
                Console.WriteLine(obj);
            }
        }
    }
}
