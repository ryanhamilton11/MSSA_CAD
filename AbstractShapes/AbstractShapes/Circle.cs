using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShapes
{
    class Circle : Shape
    {
        //FIELDS & INSTANCE VARIABLES

        private double radius = 1.0;

        //CONSTRUCTORS

        public Circle(double radius, string color) : base(color)
        {
            SetRadius(radius);
        }

        //METHODS

        public override double GetArea() => Math.PI * radius * radius;

        public override double GetPerimeter() => 2.0 * Math.PI * radius;

        public double GetRadius() => radius;


        public void SetRadius(double radius)
        {
            if (radius > 0.0)
            {
                this.radius = radius;
            }
        }
    }
}
