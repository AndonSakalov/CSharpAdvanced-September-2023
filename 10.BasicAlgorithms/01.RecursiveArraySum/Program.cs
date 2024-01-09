namespace _01.RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(SumNumbers(numbers, 0));
        }

        private static int SumNumbers(List<int> numbers, int index)
        {
            if (index == numbers.Count - 1)
            {
                return numbers[index];
            }
            return numbers[index] + SumNumbers(numbers, index + 1);
        }
    }
}