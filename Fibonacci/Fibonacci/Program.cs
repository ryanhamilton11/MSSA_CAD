using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentFib = 0;
            int nextFib = 1;

            for (int i = 0; i < 20; i++)
            {
                int nextNextFib = currentFib + nextFib;
                Console.WriteLine($"{currentFib} ");
                currentFib = nextFib;
                nextFib = nextNextFib;
            }
        }
    }
}
