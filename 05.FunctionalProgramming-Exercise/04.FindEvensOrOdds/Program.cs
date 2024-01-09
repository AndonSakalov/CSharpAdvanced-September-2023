namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, List<int>> listGenerator = (lowRange, upRange) => 
            {
                var list = new List<int>();
                for (int i = lowRange; i <= upRange; i++)
                {
                    list.Add(i);
                }
                return list;
            };

            Func<int, string, bool> evenOrOddMatch = (number, command) =>
            {
                if (command == "even")
                {
                    return number % 2 == 0;
                }
                else
                {
                    return number %2 != 0;
                }
                
            }; 
           
            int[] range = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> numbers = listGenerator(range[0], range[1]);
            string command = Console.ReadLine();
            foreach (int number in numbers)
            {
                if (evenOrOddMatch(number, command))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();

        }
    }
}