using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle
    {
        //FIELDS
        private double _radius;

        //CONSTRUCTORS

        public Circle()
        {

        }
        public Circle(double radius)
        {
            SetRadius(radius);
        }

        //METHODS
        public double GetArea() => Math.PI * _radius * _radius;

        public double GetCircumference() => 2 * Math.PI * _radius;

        public double GetRadius() => _radius;

        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
            }
            else if (radius == 0)
            {
                radius = 1.0;
            }
            _radius = radius;
        }
    }
}
