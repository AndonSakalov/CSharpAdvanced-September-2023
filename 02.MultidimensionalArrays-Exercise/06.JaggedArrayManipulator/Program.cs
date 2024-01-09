using System.Data.Common;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        if (jagged[row][col] != 0)
                        {
                            jagged[row][col] /= 2;
                        }
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        if (jagged[row + 1][col] != 0)
                        {
                            jagged[row + 1][col] /= 2;
                        }
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && row < rows && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}