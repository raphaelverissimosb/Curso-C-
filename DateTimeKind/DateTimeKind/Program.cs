using System;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, System.DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, System.DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);


            Console.WriteLine("d1: "+ d1 );
            Console.WriteLine("d1  Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local:" + d1.ToLocalTime());
            
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2  Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local:" + d2.ToLocalTime());

            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3  Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local:" + d3.ToLocalTime());
        }
    }
}
