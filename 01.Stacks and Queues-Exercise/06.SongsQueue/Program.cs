using System.Linq;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            bool isOver = false;
            while (!isOver)
            {
                string[] commandTokens = Console.ReadLine().Split();
                switch (commandTokens[0])
                {
                    case "Play":
                        if (songs.Any())
                        {
                            songs.Dequeue();
                        }
                        if (songs.Count == 0)
                        {
                            Console.WriteLine("No more songs!");
                            isOver = true;
                            break;
                        }
                        break;
                    case "Add":
                        string songToAdd = string.Join(" ", commandTokens.Skip(1));
                        if (!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
        }
    }
}