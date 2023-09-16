namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "add")
                {
                    numbers.Push(int.Parse(tokens[1]));
                    numbers.Push(int.Parse(tokens[2]));
                }
                else
                {
                    int n = int.Parse(tokens[1]);
                    if (numbers.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}