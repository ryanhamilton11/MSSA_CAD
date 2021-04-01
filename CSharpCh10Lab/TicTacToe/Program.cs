using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] ticTacToeBoard =
                {
                    { '-', '-', '-'},
                    { '-', '-', '-'},
                    { '-', '-', '-'}
                };


            for (int turns = 0; turns < 9; turns++)
            {
                char player = 'X';
                if (turns % 2 == 1)
                    player = 'O';
                int r = 3;
                int c = 3;

                while (r < 0 || r > 2 || c < 0 || c > 2)
                {
                    Console.Write($"Player {player} Enter row (1-3): ");
                    r = int.Parse(Console.ReadLine()) - 1;
                    Console.Write($"Player {player} Enter row (1-3): ");
                    c = int.Parse(Console.ReadLine()) - 1;
                    DidPlayerWin(ticTacToeBoard);
                }

                if (ticTacToeBoard[r, c] == '-')
                {
                    ticTacToeBoard[r, c] = player;
                }
                else
                {
                    Console.WriteLine("Cannot override an occupied space, you have lost your turn.");
                }

                View(ticTacToeBoard);
            }
        }

        static void View(char[,] board)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(board[j, k]);
                }
                Console.WriteLine();
            }
        }

        public static bool DidPlayerWin(char[,] board)
        {
            if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
            {
                return true;
            }
            if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                return true;
            }
            if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }
            if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
            {
                return true;
            }
            if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            if (board[0, 2] == 'X' && board[0, 1] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
            {
                return true;
            }
            if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
            {
                return true;
            }
            if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
            {
                return true;
            }
            if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
            {
                return true;
            }
            if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            if (board[0, 2] == 'O' && board[0, 1] == 'O' && board[2, 0] == 'O')
            {
                return true;
            }

            return false;
        }
    }
}
