namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < pumpsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = input[0];
                int distance = input[1];
                pumps.Enqueue(input);
            }
            int bestRoute = 0;
            while (true)
            {
                int leftFuel = 0;
                foreach (int[] pump in pumps)
                {
                    if (pump[0] + leftFuel < pump[1])
                    {
                        pumps.Enqueue(pumps.Dequeue());
                        bestRoute++;
                        leftFuel = 0;
                        break;
                    }
                    else
                    {
                        leftFuel += pump[0] - pump[1];
                    }
                }
                if (leftFuel > 0)
                {
                    break;
                }
            }

            Console.WriteLine(bestRoute);
        }
    }
}