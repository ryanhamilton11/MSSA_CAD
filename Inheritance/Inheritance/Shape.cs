using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Shape
    {
        private string _color;

        protected Shape(string color)
        {
            SetColor(color);
        }

        public string GetColor()
        {
            return _color;
        }

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
