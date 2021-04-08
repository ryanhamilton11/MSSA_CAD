using System;
using System.Linq;

namespace WealthiestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] wealth = new int[5][];

            wealth[0] = new int[5] { 100, 200, 300, 400, 500 };
            wealth[1] = new int[4] { 100, 200, 300, 400 };
            wealth[2] = new int[3] { 100, 200, 300 };
            wealth[3] = new int[2] { 100, 200 };
            wealth[4] = new int[1] { 100 };

            MaximumWealth();
        }

            public int MaximumWealth(int[][] accounts)
            {
                int maxwealth = 0;
                
                for (int i = 0; i < accounts.Length; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < accounts[i].Length; j++)
                    {
                        sum += accounts[i][j];
                    }
                    if(maxwealth < sum)
                    {
                        maxwealth = sum;
                    }
                }
                return maxwealth;
            }
    }
}
