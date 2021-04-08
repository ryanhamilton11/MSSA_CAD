using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("what operation Would you like to perform? ");
            string operation = Console.ReadLine();


            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    double addition = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {addition}");
                    break;
                case "sub":
                case "-":
                    double subtraction = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {subtraction}");
                    break;
                case "mul":
                case "*":
                    double multiplication = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");
                    break;

                case "div":
                case "/":
                    double divide = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {divide}");
                    break;

                case "rem":
                case "%":
                    double remainder = firstNumber % secondNumber;
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {remainder}");
                    break;
                default:
                    Console.WriteLine("Please enter a valid operation to compute on these two numbers.");
                    break;

            }
        }
    }
}
