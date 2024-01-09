namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>(input);
            box.Add(input);
            for (int i = 0; i < n - 1; i++)
            {
                input = int.Parse(Console.ReadLine());
                box.Add(input);
            }
            Console.WriteLine(box.ToString());
        }
    }
}