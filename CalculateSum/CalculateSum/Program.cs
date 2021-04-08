using System;

namespace CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 0 and 100");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number between 0 and 100");
            int number10 = int.Parse(Console.ReadLine());

            int numberSum = (number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10);
            Console.WriteLine($"The sum of your entered numbers equals: {numberSum}.");
        }
    }
}
