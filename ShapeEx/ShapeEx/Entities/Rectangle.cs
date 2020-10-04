using ShapeEx.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEx.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            this.Width = width;
            this.Height = height;
        }


        public override double Area()
        {
            Console.Write("Rectangle -");
            return ( Width * Height);
        }
    }
}
