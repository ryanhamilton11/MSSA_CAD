using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractShapes
{
    abstract class Shape
    {
        private string _color;

        protected Shape(string color)
        {
            SetColor(color);
        }

        public abstract double GetArea();

        public string GetColor() => _color;

        public abstract double GetPerimeter();

        public bool SetColor(string color)
        {
            if (color != null && color.Length > 0)
            {
                _color = color;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
