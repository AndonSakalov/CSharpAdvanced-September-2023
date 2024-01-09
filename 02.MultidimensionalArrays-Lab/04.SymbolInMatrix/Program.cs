namespace _04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            char[,] symbols = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    symbols[row, col] = currentRow[col];
                }
            }

            char symbolToSearch = char.Parse(Console.ReadLine());
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (symbols[row,col] == symbolToSearch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbolToSearch} does not occur in the matrix");
        }
    }
}