namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(num => num).ToArray();
            int outputSize = 0;
            if (sortedNumbers.Length >= 3)
            {
                outputSize = 3;
            }
            else
            {
                outputSize = sortedNumbers.Length;
            }
            for (int i = 0; i < outputSize; i++)
            {
                Console.Write(sortedNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}