namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double elementToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Comparer(elementToCompare));
        }
    }
}