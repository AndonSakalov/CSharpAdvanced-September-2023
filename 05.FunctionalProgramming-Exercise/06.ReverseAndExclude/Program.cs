using System.Threading.Channels;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> printer = list => Console.WriteLine(string.Join(" ", list));
            
            Func<List<int>, List<int>> reverseList = numbers =>
            {
                List<int> list = new List<int>();
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    list.Add(numbers[i]);
                }
                return list;
            };

            Func<List<int>, Predicate<int>, List<int>> filter = (numbers, predicateGenerator) => 
            {
                List<int> resultList = new List<int>();
                foreach (var number in numbers)
                {
                    if (!predicateGenerator(number))
                    {
                        resultList.Add(number);
                    }
                }
                return resultList;
            };

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> predicateGenerator = number => number % divider == 0;
            numbers = filter(numbers, predicateGenerator);
            numbers = reverseList(numbers);
            printer(numbers);

        }
    }
}