namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            int ordersCount = orders.Count();
            for (int i = 0; i < ordersCount; i++)
            {
                int currentOrder = orders.Peek();
                if (foodQuantity - currentOrder >= 0)
                {
                    foodQuantity -= orders.Dequeue();
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}