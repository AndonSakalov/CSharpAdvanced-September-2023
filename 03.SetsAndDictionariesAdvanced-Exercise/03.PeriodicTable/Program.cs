namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                chemicalElements.UnionWith(currentRow);
            }
            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}