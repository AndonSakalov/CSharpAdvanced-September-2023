namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primarySum = 0;
            int secondarySum = 0;
            for (int row = 0; row < size; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = currentRow[col];
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                    if (col == size - 1 - row)
                    {
                        secondarySum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}