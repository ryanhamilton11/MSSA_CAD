using System;
using System.Collections.Generic;
using System.Linq;

namespace Titanic
{
   public class Program
   {
      static void Main(string[] args)
    {
        List<Passenger> passengers = Titanic.GetPassengers("Titanic.Tsv");

            // Intro: The line of code above reads in a file that contains all of
            //   the passengers who were on the Titanic. Feel free to look at
            //   the Passenger class to see which fields each Passenger
            //   contains. The file is read into a List of Passengers.

            // ToDo: Write code using LInQ in order to find the answers to the
            //       following questions.
            
            Console.WriteLine("Question 1:");
            // 1) Find out whether a "Miss. Alice Cleaver" survived the accident.
            var aliceCleaver = passengers.Where(p => p.Name.Contains("Alice") && p.Name.Contains("Cleaver")).FirstOrDefault();
            var aliceCleaverSurvived = aliceCleaver.Survived;
            if (aliceCleaverSurvived == true)
            {
                Console.WriteLine("Miss. Alice Cleaver survived.");
            }
            else Console.WriteLine("Miss. Alice Cleaver did not survive.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Question 2:");
            // 2) There were six 52-year-olds on board, however, only one embarked
            //    from Cherbourg (C). What was his or her name? Did he or she
            //    survive?
            var fiftytwos = passengers.FindAll(p => p.Age == 52);
            var c52 = fiftytwos.Where(p => p.Embarked == 'C').FirstOrDefault();
            Console.WriteLine($"The 52 year old who embarked from Cherbour was: {c52.Name}");
            if (c52.Survived == true)
            {
                Console.WriteLine("Did they survive? Yes");
            }
            else Console.WriteLine("Did they survive? No");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Question 3:");
            // 3a) How many men were on board?
            var totalMen = passengers.FindAll(p => p.Gender == 'M' && p.Age >= 18);
            Console.WriteLine($"There were {totalMen.Count} men on board");
            // 3b) How many men survived?
            var survivedMen = totalMen.FindAll(p => p.Survived == true);
            Console.WriteLine($"{survivedMen.Count()} men survived.");
            // 3c) What was the survival rate of men?
            Console.WriteLine($"The survive rate of men was: {(double)survivedMen.Count() / (double)totalMen.Count()}");
            Console.WriteLine();
            Console.WriteLine();

            // ToDo (Hint): Implement the getSurvivalRate method below.



            Console.WriteLine("Question 4:");
            // 4a) How many women were on board?
            Console.WriteLine("Question 4:");
            List<Passenger> totalWoman = passengers.FindAll(p => p.Gender == 'F' && p.Age >= 18);
            Console.WriteLine($"There were {totalWoman.Count} women on board");
            // 4b) How many women survived?
            var survivedWomen = totalWoman.Where(p => p.Survived == true);
            Console.WriteLine($"{survivedWomen.Count()} women survived.");
            // 4c) What was the survival rate of women?
            Console.WriteLine($"The survive rate of women was: {getSurvivalRate(totalWoman)}");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Question 5:");
            // 5a) How many children were on board?
            var totalChildren = passengers.FindAll(p => p.Age <= 18);
            Console.WriteLine($"There were {totalChildren.Count()} children on board.");
            // 5b) How many children survived?
            var survivedChildren = totalChildren.FindAll(p => p.Survived == true);
            Console.WriteLine($"{survivedChildren.Count()} children survived.");
            // 5c) What was the survival rate of children?
            Console.WriteLine($"The survival rate of children was: {getSurvivalRate(totalChildren)}");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Question 6:");
            // 6a) Who was the youngest survivor? (name)
            var youngest = totalChildren.OrderBy(p => p.Age).FirstOrDefault();
            Console.WriteLine($"The youngest survivor was: {youngest.Name}.");
            // 6b) Who was the oldest casualty? (name)
            var oldest = passengers.OrderByDescending(p => p.Age).FirstOrDefault();
            Console.WriteLine($"THe oldest survivor was: {oldest.Name}.");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Question 7:");
            // 7a) Who had the cheapest ticket? (name) Did they survive?
            var cheapestTicket = passengers.OrderBy(p => p.Fare).FirstOrDefault();
            Console.WriteLine($"The passenger with the cheapest ticket was: {cheapestTicket.Name}.");
            if (cheapestTicket.Survived == true)
            {
                Console.WriteLine("Did they survive? Yes");
            }
            else Console.WriteLine("Did they survive? No");
            // 7b) Who had the most expensive ticket? (name) Did they survive?
            var mostExpensiveTicket = passengers.OrderByDescending(p => p.Fare).FirstOrDefault();
            Console.WriteLine($"The passenger with the most expensive ticket was: {mostExpensiveTicket.Name}.");
            if (mostExpensiveTicket.Survived == true)
            {
                Console.WriteLine("Did they survive? Yes");
            }
            else Console.WriteLine("Did they survive? No");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Question 8:");
            // 8a) What was the survival rate for all first class passengers?
            var firstClass = passengers.FindAll(p => p.Class == 1);
            Console.WriteLine($"The survival rate for all first class passengers was: {getSurvivalRate(firstClass)}");
            // 8b) What was the survival rate for all second class passengers?
            var secondClass = passengers.FindAll(p => p.Class == 2);
            Console.WriteLine($"The survival rate for all second class passengers was: {getSurvivalRate(secondClass)}");
            // 8c) What was the survival rate for all third class passengers?
            var thirdClass = passengers.FindAll(p => p.Class == 3);
            Console.WriteLine($"The survival rate for all third class passengers was: {getSurvivalRate(thirdClass)}");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Question 9:");
            // 9) What was the survival rate of girls in first class with 2 or
            //    more of any relatives?
            var firstClassGirlsWithRelatives = passengers.FindAll(p => p.Gender == 'F' && p.Age <= 18 && p.Class == 1 && p.ParentsChildren >= 2 && p.SiblingsSpouse >= 2);
            Console.WriteLine($"The survival rate of girls in first class with 2 or more of any relatives was: {getSurvivalRate(firstClassGirlsWithRelatives)}");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Question 10:");
            // 10) What was the survival rate of men in third class with no
            //     relatives onboard?
            var thridClassMenWithoutRelatives = totalMen.FindAll(p => p.Class == 3 && p.ParentsChildren == 0 && p.SiblingsSpouse == 0);
            Console.WriteLine($"The survival rate of men in third class with no relatives onboard was: {getSurvivalRate(thridClassMenWithoutRelatives)}");
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Question 11:");
            // 11) What was the survival rate of passengers who embarked from
            //     Southampton (S) and whose fare was over 10 pounds?
            var southamptonPassengers = passengers.FindAll(p => p.Embarked == 'S' && p.Fare >= 10);
            Console.WriteLine($"The survival rate of passengers who embarked from Southampton (S) and whose fare was over 10 pounds was: {getSurvivalRate(southamptonPassengers)}.");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Question 12:");
            // 12) What was the survival rate of passengers with the word "sink"
            //     in their name? (case insensitive)
            var sinkInName = passengers.FindAll(p => p.Name.Contains("Sink") || p.Name.Contains("sink"));
            Console.WriteLine($"The survival rate of passengers with the word 'sink' in their name was: {getSurvivalRate(sinkInName)}.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Question 13:");
            // 13) What was the survival rate of passengers whose ticket number
            //     included the substring "13"?
            var unluckyTicket = passengers.Where(p => p.Ticket.Contains("13"));
            Console.WriteLine($"The survival rate of passengers whose ticket number included the substring '13' was: {getSurvivalRate(unluckyTicket)}");

        } // end Main( )

        private static double getSurvivalRate(IEnumerable<Passenger> passengers)
      {
            var totalPassengers = passengers.Count();

            var survived = passengers.Where(p => p.Survived == true).Count();

            double survivalRate = (double)survived / (double)totalPassengers;

            return survivalRate;
      } // end getSurvivalRate( )
   }
}
