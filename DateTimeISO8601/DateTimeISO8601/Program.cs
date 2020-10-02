using System;

namespace DateTimeISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15  113:05:58");

            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");


        }
    }
}
