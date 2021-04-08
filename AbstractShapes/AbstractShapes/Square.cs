using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShapes
{
    class Square : Shape
    {
        //FIELDS

        private double side = 1.0;

        //CONSTRUCTORS

        public Square(double side, string color) : base(color)
        {
            SetSide(side);
        }

        //METHODS

        public override double GetArea() => side * side;

        public override double GetPerimeter() => 4 * side;

        public double GetSide() => side;

        public void SetSide(double side)
        {
            if (side > 0)
            {
                this.side = side;
            }
        }
    }
}
