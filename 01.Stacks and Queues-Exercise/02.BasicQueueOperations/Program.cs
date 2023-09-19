namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int elementToSearch = input[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}