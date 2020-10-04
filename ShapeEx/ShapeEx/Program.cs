using System;
using System.Collections.Generic;
using ShapeEx.Entities.Enums;
using ShapeEx.Entities;
using System.Globalization;

namespace ShapeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the numbers os the shapes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.WriteLine("Rectangle or Circle (r/c) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter with the color:(Black/Red/Blue)");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.WriteLine("Enter with the width:");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Enter with the height:");    
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else {
                    
                    Console.WriteLine("Enter with the Radius:");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("Shape Areas");

            foreach (Shape fig in list) {
                Console.WriteLine(fig.Area().ToString("F2",CultureInfo.InvariantCulture));    
            }

        }
    }
}
