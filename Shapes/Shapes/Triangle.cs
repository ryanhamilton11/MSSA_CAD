using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Triangle
    {
        //FIELDS
        private double _sideA;
        private double _sideB;
        private double _sideC;

        //CONSTRUCTORS

        public Triangle()
        {

        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SetSideA(sideA);
            SetSideB(sideB);
            SetSideC(sideC);
        }

        //METHODS
        public double GetArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            double area = Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
            return area;
        }

        public double GetPerimeter() => 2 * (_sideA + _sideB + _sideC);

        public double GetSideA() => _sideA;
        public double GetSideB() => _sideB;
        public double GetSideC() => _sideC;

        public void SetSideA(double sideA)
        {
            if (sideA < 0)
            {
                sideA = -sideA;
            }
            else if (sideA == 0)
            {
                sideA = 1.0;
            }
            _sideA = sideA;
        }

        public void SetSideB(double sideB)
        {
            if (sideB < 0)
            {
                sideB = -sideB;
            }
            else if (sideB == 0)
            {
                sideB = 1.0;
            }
            _sideB = sideB;
        }

        public void SetSideC(double sideC)
        {
            if (sideC < 0)
            {
                sideC = -sideC;
            }
            else if (sideC == 0)
            {
                sideC = 1.0;
            }
            _sideC = sideC;
        }
    }
}
