using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Lake<int> lake = new(stones);
            Console.WriteLine(string.Join(", ", lake)); 
        }
    }
}