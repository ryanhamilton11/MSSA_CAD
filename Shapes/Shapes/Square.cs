using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square
    {
        //FIELDS
        private double _side;

        //CONSTRUCTORS

        public Square()
        {

        }
        public Square(double side)
        {
            SetSide(side);
        }

        //METHODS
        public double GetArea() => _side * _side;

        public double GetPerimeter() => 4 * _side;

        public double GetSide() => _side;

        public void SetSide(double side)
        {
            if (side < 0)
            {
                side = -side;
            }
            else if (side == 0)
            {
                side = 1.0;
            }
            _side = side;
        }
    }
}
