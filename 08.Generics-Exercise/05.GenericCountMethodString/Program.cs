namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                box.Add(Console.ReadLine());
            }
            string elementToCompare = Console.ReadLine();
            Console.WriteLine(box.Comparer(elementToCompare));
        }
    }
}