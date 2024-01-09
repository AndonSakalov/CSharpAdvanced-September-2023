namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }
            for (int row = 0; row < cols; row++)
            {
                int sum = 0;
                for (int col = 0; col < rows; col++)
                {
                    sum += matrix[col, row];
                }
                Console.WriteLine(sum);
            }
        }
    }
}