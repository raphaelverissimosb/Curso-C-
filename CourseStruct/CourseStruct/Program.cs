using System;

namespace CourseStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p= new Point();
            Console.WriteLine(p) ;


           double? x1 = null;
           double? y = 10.0;

            Console.WriteLine(x1.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x1.HasValue);
            Console.WriteLine(y.HasValue);

            
        }
    }
}
