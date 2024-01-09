namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currentChar = matrix[row, col];
                    char rightChar = matrix[row, col + 1];
                    char belowChar = matrix[row + 1, col];
                    char diagonalChar = matrix[row + 1, col + 1];
                    if (currentChar == rightChar && currentChar == rightChar && currentChar == belowChar && currentChar == diagonalChar)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}