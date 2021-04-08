using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Square
    {
        //FIELDS

        private double side = 1.0;


        //CONSTRUCTORS

        public Square(double side, string color) : base(color)
        {
            SetSide(side);
        } // end Square( )


        //METHODS

        public double GetArea()
        {
            return side * side;
        } // end GetArea( )

        public double GetPerimeter()
        {
            return 4 * side;
        } // end GetPerimeter( )

        public double GetSide()
        {
            return side;
        } // end GetSide( )

        public void SetSide(double side)
        {
            if (side > 0)
            {
                this.side = side;
            }
        } // end SetSide( )
    }
}
