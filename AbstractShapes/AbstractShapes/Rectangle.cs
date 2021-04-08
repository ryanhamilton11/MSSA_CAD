using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShapes
{
    class Rectangle : Shape
    {
        //FIELDS

        private double length = 1.0;
        private double width = 1.0;

        //CONSTRUCTORS

        public Rectangle(double length, double width, string color) : base(color)
        {
            SetDimensions(length, width);
        }

        //METHODS

        public override double GetArea() => length * width;

        public override double GetPerimeter() => (length + width) * 2;

        public double GetLength() => length;

        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        }

        public double GetWidth() => width;

        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }

        public (double l, double w) GetDimensions() => (length, width);

        public void SetDimensions(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        }
    }
}
