using System;

namespace AbstractShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5, "Red");
            Console.WriteLine(c1.GetArea());
            Console.WriteLine(c1.GetPerimeter());
            bool worked = c1.SetColor("Red");
            bool worked2 = c1.SetColor(null);
            bool worked3 = c1.SetColor("");
            Console.WriteLine(c1.GetColor());

            Shape s = new Square(2, "Blue");
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
        }
    }
}
