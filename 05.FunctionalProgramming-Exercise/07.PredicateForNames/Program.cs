namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charLimit = int.Parse(Console.ReadLine());
            Predicate<string> validNameFilter = name => name.Length <= charLimit;
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string name in names)
            {
                if (validNameFilter(name))
                {
                    Console.WriteLine(name);
                }
            }
            
        }
    }
}