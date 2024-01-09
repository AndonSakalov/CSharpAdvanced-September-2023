namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> filter = num => num % 2 == 0;
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            arr = arr.Where(filter).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }
       
    }
}