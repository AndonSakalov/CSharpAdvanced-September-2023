using System.Reflection.Emit;

namespace _02.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int mouseRow = 0;
            int mouseCol = 0;
            int cheeseCount = 0;
            char[,] cupboard = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    cupboard[row, col] = currentRow[col];
                    if (cupboard[row, col] == 'M')
                    {
                        mouseRow = row;
                        mouseCol = col;
                        cupboard[row, col] = '*';
                    }
                    if (cupboard[row, col] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "danger")
            {
                if (command == "left")
                {
                    if (mouseCol - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }
                    //if (cupboard[mouseRow, mouseCol - 1] == '*')
                    //{
                        
                    //}
                    if (cupboard[mouseRow, mouseCol - 1] == 'C')
                    {
                        cupboard[mouseRow, mouseCol - 1] = '*';
                        cheeseCount--;
                        if (cheeseCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            mouseCol--;
                            break;
                        }
                        continue;
                    }
                    if (cupboard[mouseRow, mouseCol - 1] == '@')
                    {
                        continue;
                    }
                    if (cupboard[mouseRow, mouseCol - 1] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        mouseCol--;
                        break;
                    }
                    mouseCol--;
                }

                if (command == "right")
                {
                    if (mouseCol + 1 > cols - 1)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }
                    //if (cupboard[mouseRow, mouseCol + 1] == '*')
                    //{
                    //    mouseCol++;
                    //}
                    if (cupboard[mouseRow, mouseCol + 1] == 'C')
                    {
                        cupboard[mouseRow, mouseCol - 1] = '*';
                        cheeseCount--;
                        if (cheeseCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            mouseCol++;
                            break;
                        }
                    }
                    if (cupboard[mouseRow, mouseCol + 1] == '@')
                    {
                        continue;
                    }
                    if (cupboard[mouseRow, mouseCol + 1] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        mouseCol++;
                        break;
                    }
                    mouseCol++;
                }

                if (command == "up")
                {
                    if (mouseRow - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        mouseRow--;
                        break;
                    }
                    //if (cupboard[mouseRow - 1, mouseCol] == '*')
                    //{
                        
                    //}
                    if (cupboard[mouseRow - 1, mouseCol] == 'C')
                    {
                        cupboard[mouseRow - 1, mouseCol] = '*';
                        cheeseCount--;
                        if (cheeseCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            mouseRow--;
                            break;
                        }
                    }
                    if (cupboard[mouseRow - 1, mouseCol] == '@')
                    {
                        continue;
                    }
                    if (cupboard[mouseRow - 1, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        mouseRow--;
                        break;
                    }
                    mouseRow--;
                }

                if (command == "down")
                {
                    if (mouseRow + 1 > rows - 1)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        mouseRow++;
                        break;
                    }
                    //if (cupboard[mouseRow + 1, mouseCol] == '*')
                    //{
                       
                    //}
                    if (cupboard[mouseRow + 1, mouseCol] == 'C')
                    {
                        cupboard[mouseRow + 1, mouseCol] = '*';
                        cheeseCount--;
                        if (cheeseCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            mouseRow++;
                            break;
                        }
                    }
                    if (cupboard[mouseRow + 1, mouseCol] == '@')
                    {
                        continue;
                    }
                    if (cupboard[mouseRow + 1, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        mouseRow++;
                        break;
                    }
                     mouseRow++;
                }
            }
            if (cheeseCount != 0 && command == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }
            cupboard[mouseRow, mouseCol] = 'M';
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(cupboard[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}