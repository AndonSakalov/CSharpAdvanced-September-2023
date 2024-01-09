namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            CustomStack<int> stack = new CustomStack<int>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "Push":
                        int[] numbers = command.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                            .Skip(1)
                            .Select(int.Parse)
                            .ToArray();

                        stack.Push(numbers);
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}