namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, string, List<int>> commandExecuter = (numbers, command) =>
            {
                List<int> list = new List<int>();
                switch (command)
                {
                    case "add":
                        foreach (int num in numbers)
                        {
                            list.Add(num + 1);
                        }
                        break;
                    case "multiply":
                        foreach (int num in numbers)
                        {
                            list.Add(num * 2);
                        }
                        break;
                    case "subtract":
                        foreach (int num in numbers)
                        {
                            list.Add(num - 1);
                        }
                        break;
                    default:
                        break;
                }
                return list;
            };

            Action<List<int>> printer = list => Console.WriteLine(string.Join(" ", list));

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    printer(numbers);
                }
                else
                {
                    numbers = commandExecuter(numbers, command); 
                }
            }
        }
    }
}