using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShapes
{
    class Triangle : Shape
    {
        //FIELDS

        private double a = 1.0;
        private double b = 1.0;
        private double c = 1.0;

        //CONSTRUCTORS 

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            SetSides(a, b, c);
        }

        //METHODS

        public override double GetArea()   // Heron's Formula
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public override double GetPerimeter() => a + b + c;

        public double GetSideA() => a;

        public double GetSideB() => b;

        public double GetSideC() => c;
        public (double a, double b, double c) GetSides() => (a, b, c);

        public void SetSides(double a, double b, double c)
        {
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
    }
}
