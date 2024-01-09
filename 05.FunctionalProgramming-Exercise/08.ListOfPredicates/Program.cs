namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisible = (number, divider) =>
            {
                return number % divider == 0;
            };

            int endRange = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, endRange).ToList();
            HashSet<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();
            foreach (int number in numbers)
            {
                bool isValid = true;
                foreach (int divider in dividers)
                {
                    if (!isDivisible(number,divider))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }
    }
}