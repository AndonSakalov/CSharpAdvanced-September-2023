using System.Data.Common;

namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    chessBoard[row, col] = currentRow[col];
                }
            }
            if (size <= 2)
            {
                Console.WriteLine(0);
                return;
            }
            int removedHorses = 0;
            while (true)
            {
                int mostAgressiveHorseRow = 0;  //poss prob
                int mostAgressiveHorseCol = 0;  //poss prob
                int attackedHorses = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (chessBoard[row, col] == 'K')
                        {
                            int currentHorse = CheckHorsesToAttack(chessBoard, row, col);
                            if (currentHorse > attackedHorses)
                            {
                                mostAgressiveHorseRow = row;
                                mostAgressiveHorseCol = col;
                                attackedHorses = currentHorse;
                            }
                        }
                    }
                }
                if (attackedHorses > 0)
                {
                    chessBoard[mostAgressiveHorseRow, mostAgressiveHorseCol] = '0';
                    removedHorses++;
                }
                else
                {
                    Console.WriteLine(removedHorses);
                    break;
                }
            }
        }

        private static int CheckHorsesToAttack(char[,] chessBoard, int row, int col)
        {
            int attackedHorses = 0;
            if (isValid(chessBoard, row - 2, col + 1) && isK(chessBoard, row - 2, col + 1))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row - 2, col - 1) && isK(chessBoard, row - 2, col - 1))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row + 2, col + 1) && isK(chessBoard, row + 2, col + 1))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row + 2, col - 1) && isK(chessBoard, row + 2, col - 1))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row - 1, col + 2) && isK(chessBoard, row -1 , col + 2))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row + 1, col + 2) && isK(chessBoard, row + 1, col + 2))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row - 1, col - 2) && isK(chessBoard, row - 1, col - 2))
            {
                attackedHorses++;
            }
            if (isValid(chessBoard, row + 1, col - 2) && isK(chessBoard, row + 1, col - 2))
            {
                attackedHorses++;
            }
            return attackedHorses;
        }

        private static bool isK(char[,] chessBoard, int row, int col)
        {
            if (chessBoard[row, col] == 'K')
            {
                return true;
            }

            return false;
        }

        private static bool isValid(char[,] chessBoard, int row, int col)
        {
            if (row >= 0 && col <= chessBoard.GetLength(1) - 1 && col >= 0 && row <= chessBoard.GetLength(0) - 1)
            {
                return true;
            }

            return false;

        }
    }
}