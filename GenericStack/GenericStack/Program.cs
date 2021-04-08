using System;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myInts = new Stack<int>(10);
            myInts.Push(1);
            myInts.Push(2);
            bool isFull = myInts.isFull();
            bool isEmpty = myInts.isEmpty();
            int x = myInts.Pop();
            Console.WriteLine(x);


            Stack<string> myStrings = new Stack<string>(10);
            myStrings.Push("One");
            myStrings.Push("Two");
            isFull = myStrings.isFull();
            isEmpty = myStrings.isEmpty();
            string s = myStrings.Pop();
            Console.WriteLine(s);

            Stack<char> myChars = new Stack<char>(10);
            myChars.Push('A');
            myChars.Push('B');
            isFull = myChars.isFull();
            isEmpty = myChars.isEmpty();
            char c = myChars.Pop();
            Console.WriteLine(c);


            CharStack charStackFive = new CharStack(5);
            charStackFive.Push('A');
            charStackFive.Push('B');
            charStackFive.Push('C');
            charStackFive.Push('D');
            Console.WriteLine(charStackFive.isFull()); // false
            charStackFive.Push('E');
            Console.WriteLine(charStackFive.isFull()); // true


            StringStack threeStrings = new StringStack(3);
            threeStrings.Push("Hello");
            threeStrings.Push("World");
            Console.WriteLine(threeStrings.isFull()); // false
            threeStrings.Push("Goodbye");
            Console.WriteLine(threeStrings.isFull()); //true
            string st = threeStrings.Pop(); //Goodbye
            Console.WriteLine(s);
            Console.WriteLine(threeStrings.isFull()); //false

            IntStack tenInts = new IntStack(10);
            bool mt = tenInts.isEmpty(); //true
            bool full = tenInts.isFull(); //false

            tenInts.Push(123);
            mt = tenInts.isEmpty(); //false
            full = tenInts.isFull(); //false


            tenInts.Push(456);
            tenInts.Push(-1);
            
            int v1 = tenInts.Pop(); //-1
            int v2 = tenInts.Pop(); //456
            tenInts.Pop();
            tenInts.Pop();

            tenInts.Push(789);
            tenInts.Push(111);
            tenInts.Push(222);
            tenInts.Push(333);
            tenInts.Push(444);
            tenInts.Push(555);
            tenInts.Push(666);
            tenInts.Push(667);
            tenInts.Push(777);
            full = tenInts.isFull(); //false

            tenInts.Push(888);
            full = tenInts.isFull(); //true

            tenInts.Push(789);
            tenInts.Push(789);
        }
    }
}
