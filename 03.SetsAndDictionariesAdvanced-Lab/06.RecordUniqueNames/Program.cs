namespace _06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namesCount = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < namesCount; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}