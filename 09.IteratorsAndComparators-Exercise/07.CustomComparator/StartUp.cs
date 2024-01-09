using System.Collections;

namespace _07.CustomComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(arr, new Comparer());
            Console.WriteLine(string.Join(" ", arr));

        }
    }
    public class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1; 
            }
            if (x % 2 != 0 && y % 2 == 0)
            {
                return 1;
            }
            return x.CompareTo(y);
        }
    }
}