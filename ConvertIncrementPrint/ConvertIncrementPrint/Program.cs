using System;

namespace ConvertIncrementPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "17";
            int count = System.Int32.Parse(input);
            ++count;
            Console.WriteLine($"{count}");
        }
    }
}
