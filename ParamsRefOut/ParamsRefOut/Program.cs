using System;

namespace ParamsRefOut
{
    class Program
    {
        static void Main(string[] args)
        {



            int a = 10;
            int triple;
            Calculator.Triple( ref a);
            Console.WriteLine(a);
            Calculator.Triple2(a, out triple);
            Console.WriteLine(triple);

        }
    }
}
