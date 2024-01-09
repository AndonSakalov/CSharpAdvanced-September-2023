using System.Data;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                if (command.Length != 5) 
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);
                if (command[0] != "swap" || row1 >= matrix.GetLength(0) || row2 >= matrix.GetLength(0) || col1 >= matrix.GetLength(1) || col2 >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                SwapValues(matrix, row1, row2, col1, col2);
                PrintMatrix(matrix, rows, cols);
            }
        }

        private static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SwapValues(string[,] matrix, int row1, int row2, int col1, int col2)
        {
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;
        }
    }
}