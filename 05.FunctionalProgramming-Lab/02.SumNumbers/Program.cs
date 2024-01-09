using System.Diagnostics.Metrics;

namespace _02.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> counter = c => c.Length;
            Func<int[], int> sum = c => c.Sum();
            int[] arr = Console.ReadLine().
                Split(", ").
                Select(int.Parse).
                ToArray();
            Console.WriteLine($"{counter(arr)}\n{sum(arr)}");
        }
    }
}