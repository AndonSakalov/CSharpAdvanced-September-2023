namespace _01.TempleOfDoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> substances = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            bool isLost = false;
            List<int> challenges = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            while (challenges.Count > 0)
            {
                int currentTool = tools.Dequeue();
                int currentSubstance = substances.Pop();
                int result = currentSubstance * currentTool;
                if (challenges.Contains(result))
                {
                    challenges.Remove(result);
                }
                else
                {
                    tools.Enqueue(currentTool + 1);
                    substances.Push(currentSubstance - 1);
                    if (substances.Peek() == 0)
                    {
                        substances.Pop();
                    }
                }

                if ((substances.Count == 0 || tools.Count == 0) && challenges.Count > 0)
                {
                    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                    isLost = true;
                    break;
                }
            }

            if (challenges.Count == 0)
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }

            if (tools.Any())
            {
                Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            }

            if (substances.Any())
            {
                Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            }

            if (isLost)
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}