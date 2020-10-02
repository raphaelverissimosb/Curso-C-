using System;
using System.Globalization;

namespace DatesTimeType
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            //DateTime possui varias sobrecargas de metodo e outros builders
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018,11,25);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45,03);
            Console.WriteLine(d2);

            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow; // especifica o horario universal em Grainwitch 


            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);


            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d8);


            DateTime d9 = DateTime.ParseExact("15/08/2020 13:05:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
