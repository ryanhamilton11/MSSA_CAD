using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9, };
            int[] c = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
        }

        public static int Sum(int[] z)
        {
            int result = 0;
            foreach (int i in z)
            {
                result += i;
            }
            return result;
        }

        public double Avg(int[] z) => Sum(z) / z.Length;


        public static void Reverse(int[] z)
        {
            int[] revArray = new int[z.Length];

            for (int i = 0; i < z.Length / 2; i++)
            {
                int tmpArray = z[i];
                z[i] = z[z.Length - i - 1];
                z[z.Length - i - 1] = tmpArray;
            }
        }

        public static int Maximum(int[] z)
        {
            int max = z[0];
            foreach (int i in z)
            {
                if (z[i] > max)
                {
                    max = z[i];
                }
            }
            return max;
        }

        public static void Rotate(int[] startArray, int numRotate)
        {
            int[] rotateArray = new int[startArray.Length];

            int index;
            int length = startArray.Length;
            int place;


            for (int i = 0; i < length; i++)
            {
                index = i - numRotate;
                place = length + index;
                if (index >= 0)
                {
                    rotateArray[index] = startArray[i];
                }
                else
                {
                    rotateArray[place] = startArray[i];
                }
            }
        }

        public static void Sort(int[] z)
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
