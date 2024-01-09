namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int index = 0;
            char[,] matrix = new char[rows, cols];
            string snakeWord = Console.ReadLine();
            char[] snakeChars = snakeWord.ToCharArray();
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snakeChars[0];
                        for (int i = 0; i < snakeChars.Length - 1; i++)
                        {
                            char temp = snakeChars[i];
                            snakeChars[i] = snakeChars[i + 1];
                            snakeChars[i + 1] = temp;
                        }

                        Console.Write(matrix[row, col]);
                    }
                }

                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeChars[0];
                        for (int i = 0; i < snakeChars.Length - 1; i++)
                        {
                            char temp = snakeChars[i];
                            snakeChars[i] = snakeChars[i + 1];
                            snakeChars[i + 1] = temp;
                        }
                    }

                    for (int cwCol = 0; cwCol < cols; cwCol++)
                    {
                        Console.Write(matrix[row, cwCol]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}