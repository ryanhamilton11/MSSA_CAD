using System.Collections.Generic;

namespace Titanic
{
   public class Program
   {
      static void Main(string[] args)
      {
         List<Passenger> passengers = Titanic.GetPassengers("Titanic.Tsv");

         // Intro: The line of code above reads in a file that contains all of
         //        the passengers who were on the Titanic. Feel free to look at
         //        the Passenger class to see which fields each Passenger
         //        contains. The file is read into a List of Passengers.

         // ToDo: Write code using LInQ in order to find the answers to the
         //       following questions.

         // 1) Find out whether a "Miss. Alice Cleaver" survived the accident.

         // 2) There were six 52-year-olds on board, however, only one embarked
         //    from Cherbourg (C). What was his or her name? Did he or she
         //    survive?

         // 3a) How many men were on board?
         // 3b) How many men survived?
         // 3c) What was the survival rate of men?

         // ToDo (Hint): Implement the getSurvivalRate method below.

         // 4a) How many women were on board?
         // 4b) How many women survived?
         // 4c) What was the survival rate of women?

         // 5a) How many children were on board?
         // 5b) How many children survived?
         // 5c) What was the survival rate of children?

         // 6a) Who was the youngest survivor? (name)
         // 6b) Who was the oldest casualty? (name)

         // 7a) Who had the cheapest ticket? (name) Did they survive?
         // 7b) Who had the most expensive ticket? (name) Did they survive?

         // 8a) What was the survival rate for all first class passengers?
         // 8b) What was the survival rate for all second class passengers?
         // 8c) What was the survival rate for all third class passengers?

         // 9) What was the survival rate of girls in first class with 2 or
         //    more of any relative?

         // 10) What was the survival rate of men in third class with no
         //     relatives onboard?

         // 11) What was the survival rate of passengers who embarked from
         //     Southampton (S) and whose fare was over 10 pounds?

         // 12) What was the survival rate of passengers with the word "sink"
         //     in their name? (case insensitive)

         // 13) What was the survival rate of passengers whose ticket number
         //     included the substring "13"?

      } // end Main( )

      private static double getSurvivalRate(IEnumerable<Passenger> passengers)
      {
         double survivalRate = 0.0;

         // ToDo: Implement this method.

         return survivalRate;
      } // end getSurvivalRate( )
   }
}
