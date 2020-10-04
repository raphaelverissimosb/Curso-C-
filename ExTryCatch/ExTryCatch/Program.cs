using System;

namespace ExTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by Zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error !" + e.Message);
            }
            finally
            {

            }


        }
    }
}
