namespace _07.BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            list = list.OrderBy(x => x).ToList();
            int numberToSearch = int.Parse(Console.ReadLine());
            int index = FindNumberInSortedList(list, numberToSearch, 0, list.Count - 1);
            Console.WriteLine(index);
        }

        static int FindNumberInSortedList(List<int> list, int numberToSearch, int start, int end)
        {
            if (end <= -1 || start > list.Count - 1 || end < start)
            {
                return -1;
            }
            int middle = (start + end) / 2;
            if (list[middle] == numberToSearch)
            {
                return middle;
            }
            if (list[middle] < numberToSearch)
            {
                return FindNumberInSortedList(list, numberToSearch, middle + 1, end);
            }
            else
            {
                return FindNumberInSortedList(list, numberToSearch, start, middle - 1);
            }
        }
    }
}