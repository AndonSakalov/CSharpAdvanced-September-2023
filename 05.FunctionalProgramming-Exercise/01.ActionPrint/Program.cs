namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printer = names =>Console.WriteLine(string.Join(Environment.NewLine, names));
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            printer(names);
        }
    }
}