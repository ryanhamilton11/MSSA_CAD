using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        //FIELDS
        private double _length;
        private double _width;

        //CONSTRUCTORS

        public Rectangle()
        {

        }
        public Rectangle(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        }

        //METHODS
        public double GetArea() => _length * _width;

        public double GetPerimeter() => 2 * (_length + _width);

        public double GetLength() => _length;

        public double GetWidth() => _width;

        public void SetLength(double length)
        {
            if (length < 0)
            {
                length = -length;
            }
            else if (length == 0)
            {
                length = 1.0;
            }
            _length = length;
        }

        public void SetWidth(double width)
        {
            if (width < 0)
            {
                width = -width;
            }
            else if (width == 0)
            {
                width = 1.0;
            }
            _width = width;
        }
    }
}
