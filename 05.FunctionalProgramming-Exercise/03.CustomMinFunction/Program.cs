namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<HashSet<int>, int> smallesNumberInArr = numbers =>
            {
                int minNumber = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }
                return minNumber;
            };
            HashSet<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();
            Console.WriteLine(smallesNumberInArr(numbers));
        }
    }
}