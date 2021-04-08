using System;

namespace BulletProofConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = IntCheck();
            double y = DoubleCheck();
        }
        static int IntCheck()
        {
            int y = 0;
            bool succeedInt = false;

            while (succeedInt == false)
            {
                try
                {
                    Console.Write("Please enter a integer: ");
                    y = int.Parse(Console.ReadLine());
                    succeedInt = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return y;
        }

        static double DoubleCheck()
        {
            double x = 0;
            bool succeedDouble = false;

            while (succeedDouble == false)
            {
                try
                {
                    Console.Write("Please enter a double: ");
                    x = double.Parse(Console.ReadLine());
                    succeedDouble = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return x;
        }
    }
}
