using System;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = GetAmount("Purchase Price: ");

            while (price <= 0)
            {
                Console.WriteLine("Please enter a value greater than zero. ");
                price = GetAmount("Purchase Price: ");
            }

            double payment = GetAmount("Payment Amount: ");

            if (price > payment)
            {
                Console.WriteLine("Insifficient funds, please enter a different amount.");
                payment = GetAmount("Payment Amount: ");
                GiveDenominations(price, payment);
            }
            else
            {
                GiveDenominations(price, payment);
            }
        }

        static double GetAmount(string prompt)
        {
            string inValue;
            double outcome;
            bool numbercheck = false;
            Console.Write(prompt);
            //inValue = Console.ReadLine();
            outcome = 0;

            while (numbercheck == false)
            {
                try
                {
                    inValue = Console.ReadLine();
                    outcome = double.Parse(inValue);
                    numbercheck = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write("Please enter another amount: ");
                }
            }
            return outcome;

        }

        static void GiveDenominations(double purchaseAmount, double paymentAmount)
        {
            double changeDue = paymentAmount - purchaseAmount;
            Console.WriteLine($"Change Due: {changeDue.ToString("C")}");
            changeDue += 0.0000001;

            double newChangeDue = Denominate(changeDue, 20.00);
            newChangeDue = Denominate(newChangeDue, 10.00);
            newChangeDue = Denominate(newChangeDue, 5.00);
            newChangeDue = Denominate(newChangeDue, 1.00);
            newChangeDue = Denominate(newChangeDue, .25);
            newChangeDue = Denominate(newChangeDue, .10);
            newChangeDue = Denominate(newChangeDue, .05);
            newChangeDue = Denominate(newChangeDue, .01);

            return;
        }

        static double Denominate(double changeDue, double denomication)
        {
            int count = (int)(changeDue / denomication);

            if (count > 0)
            {
                Console.WriteLine($"{count} {denomication.ToString("C")}s");
            }
            changeDue = changeDue % denomication;
            return changeDue;
        }
    }
}
