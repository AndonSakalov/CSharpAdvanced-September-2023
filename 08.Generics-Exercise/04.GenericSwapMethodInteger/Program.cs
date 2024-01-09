namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            int[] swapCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SwapElements(swapCommand[0], swapCommand[1], numbers);
            foreach (var number in numbers)
            {
                Print(number);
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
