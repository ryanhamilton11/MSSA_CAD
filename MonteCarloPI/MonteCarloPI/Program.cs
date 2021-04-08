using System;

namespace MonteCarloPI
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rnd = new System.Random();
            int iterations;
            iterations = int.Parse(args[0]);

            int countinside = 0;
            int countoutside = 0;

            for (int i = 0; i < iterations; i++)
            {
                double x;
                double y;
                (x, y) = RandomXY(rnd);

                double c = Hypotenuse(x, y);
                Console.WriteLine(c);
                if (c <= 1.0)
                {
                    countinside++;
                }
                else
                {
                    countoutside++;
                }
            }

            Console.WriteLine($"Values under 1: {countinside}");
            Console.WriteLine($"Values over 1: {countoutside}");

            double myPi = 4.0 * countinside / iterations;
            Console.WriteLine($"My estimate of PI is: {myPi}");
            myPi -= Math.PI;
            Console.WriteLine($"The difference between my estimate of PI and the actual value of PI is: {myPi}");
        }

        static (double x, double y) RandomXY(System.Random rnd)
        {
            double x = rnd.NextDouble();
            Console.WriteLine(x);
            double y = rnd.NextDouble();
            Console.WriteLine(y);
            return (x, y);
        }

        static double Hypotenuse(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
}
