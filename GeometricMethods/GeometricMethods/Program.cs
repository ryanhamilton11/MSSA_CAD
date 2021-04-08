using System;

namespace GeometricMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double circle1Radius = 1.0;
            double circle1Area = GetArea(circle1Radius); // 3.14159...
            double circle1Perimeter = GetPerimeter(circle1Radius); // 6.28318...
            Console.WriteLine("Circle 1      Area: " + circle1Area);
            Console.WriteLine("Circle 1 Perimeter: " + circle1Perimeter);
            Console.WriteLine();

            double rectangleLength = 2.0;
            double rectangleWidth = 3.0;
            double rectangleArea = GetArea(rectangleLength, rectangleWidth);
            double rectanglePerimeter = GetPerimeter(rectangleLength, rectangleWidth);
            Console.WriteLine("Rectangle      Area: {0}", rectangleArea);
            Console.WriteLine("Rectangle Perimeter: {0}", rectanglePerimeter);
            Console.WriteLine();

            double triangleSideA = 4.0;
            double triangleSideB = 5.0;
            double triangleSideC = 6.0;
            double triangleArea = GetArea(triangleSideA, triangleSideB, triangleSideC);
            double trianglePerimeter = GetPerimeter(triangleSideA, triangleSideB, triangleSideC);
            Console.WriteLine($"Triangle      Area: {triangleArea}");
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");
            Console.WriteLine();

            (circle1Area, circle1Perimeter) = GetAreaAndPerimeter(1.0);
            Console.WriteLine($"Circle 1      Area: {circle1Area}");
            Console.WriteLine($"Circle 1 Perimeter: {circle1Perimeter}");
            Console.WriteLine();
        }

        static double GetArea(double radius) // Circle
        {
            return Math.PI * (radius * radius);
        }

        static double GetArea(double length, double width) // Rectangle
        {
            return length * width;
        }

        static double GetArea(double a, double b, double c) // Triangle
        {
            double s = (a + b + c) / 2.0d;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static double GetPerimeter(double radius) // Circle
        {
            return 2 * (Math.PI * radius);
        }

        static double GetPerimeter(double length, double width) // Rectangle
        {
            return ((2 * length) + (2 * width));
        }

        static double GetPerimeter(double a, double b, double c) // Triangle
        {
            return (a + b + c);
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double radius) // Circle
        {
            double area = GetArea(radius);
            double perimeter = GetPerimeter(radius);
            return (area, perimeter);
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double length, double width) // Rectangle
        {
            double area = GetArea(length, width);
            double perimeter = GetPerimeter(length, width);
            return (area, perimeter);
        }

        static (double area, double perimeter) GetAreaAndPerimeter(double a, double b, double c) // Triangle
        {
            double area = GetArea(a, b, c);
            double perimeter = GetPerimeter(a, b, c);
            return (area, perimeter);
        }
    }
}
