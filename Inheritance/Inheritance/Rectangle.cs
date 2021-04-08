using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Rectangle
    {
        //FIELDS

        private double length = 1.0;
        private double width = 1.0;


        //CONSTRUCTORS

        public Rectangle(double length, double width, string color) : base(color)
        {
            SetDimensions(length, width);
        } // end Rectangle( )


        //METHODS

        public double GetArea()
        {
            return length * width;
        } // end GetArea( )

        public double GetPerimeter()
        {
            return (length + width) * 2;
        } // end GetPerimeter( )

        public double GetLength()
        {
            return length;
        } // end GetLength( )

        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
        } // end SetLength( )

        public double GetWidth()
        {
            return width;
        } // end GetWidth( )

        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        } // end SetWidth( )

        public (double l, double w) GetDimensions()
        {
            return (length, width);
        } // end GetDimensions( )

        public void SetDimensions(double length, double width)
        {
            SetLength(length);
            SetWidth(width);
        } // end SetDimensions( )
    }
}
