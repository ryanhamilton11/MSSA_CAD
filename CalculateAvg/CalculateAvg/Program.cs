using System;

namespace CalculateAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore9 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a test score between 0 and 100");
            double testScore10 = int.Parse(Console.ReadLine());

            double testScoreAverage = ((testScore1 + testScore2 + testScore3 + testScore4 + testScore5 + testScore6 + testScore7 + testScore8 + testScore9 + testScore10) / 10);
            Console.WriteLine($"The average of your test scores is: {testScoreAverage}.");
        }
    }
    }
}
