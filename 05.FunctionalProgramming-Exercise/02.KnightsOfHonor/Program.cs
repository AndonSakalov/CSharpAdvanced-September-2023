namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[], string> printer = (names, title) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string title = "Sir";
            printer(names,title);
        }
    }
}