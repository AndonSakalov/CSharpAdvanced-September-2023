namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Box<string> box = new Box<string>(input);
            box.Add(input);
            for (int i = 0; i < n - 1; i++)
            {
                input = Console.ReadLine();
                box.Add(input);
            }
            Console.WriteLine(box.ToString());
        }
    }
}