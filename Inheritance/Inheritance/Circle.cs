using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Circle
    {
        //FIELDS (INSTANCE VARIABLES)

        private double radius = 1.0;


        //CONSTRUCTORS

        public Circle(double radius, string color) : base(color)
        {
            SetRadius(radius);
        } // end Circle( )


        //METHODS

        public double GetArea()
        {
            return Math.PI * radius * radius;
        } // end GetArea( )

        public double GetCircumference()
        {
            return 2.0 * Math.PI * radius;
        } // end GetCircumference( )

        public double GetRadius()
        {
            return radius;
        } // end GetRadius( )

        public void SetRadius(double radius)
        {
            if (radius > 0.0)
            {
                this.radius = radius;
            }
        }
    }
}
