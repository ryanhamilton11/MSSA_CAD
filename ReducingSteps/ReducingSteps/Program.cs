using System;

namespace ReducingSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            int n = int.Parse(Console.ReadLine());
            int num = NumberOfSteps(n);
            Console.WriteLine($"{num}");
        }

        static int NumberOfSteps(int num)
        {
            int count = 0;

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    count++;
                }
                else
                {
                    if (num == 1)
                    {
                        return count + 1;
                    }
                    num = num - 1;
                    count++;
                }
            }
            return count;
        }
    }
}
