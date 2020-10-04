using ShapeEx.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEx.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)  : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            Console.Write("Circle -");
            return Math.PI * Math.Pow(2,Radius) ;
        }
    }
}
