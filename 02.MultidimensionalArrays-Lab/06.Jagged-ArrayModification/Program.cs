namespace _06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] command = input.Split();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || col < 0 || row >= jagged.GetLength(0) || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command[0] == "add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}