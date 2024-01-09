using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                words.Add(word);
            }
            int[] swapCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SwapElements(swapCommand[0], swapCommand[1], words);
            foreach (var word in words)
            {
                Print(word);
            }
        }
        static void SwapElements<T>(int index1, int index2, List<T> words)
        {
            (words[index1], words[index2]) = (words[index2], words[index1]);
        }
        static void Print<T>(T word)
        {
            Console.WriteLine($"{typeof(T)}: {word}");
        }
    }
}