using ShapeEx.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeEx.Entities
{
    abstract class  Shape
    {
        public Color Color { get; set; }
/*        public Shape()
        {

        }*/
        public Shape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();


    }
}
