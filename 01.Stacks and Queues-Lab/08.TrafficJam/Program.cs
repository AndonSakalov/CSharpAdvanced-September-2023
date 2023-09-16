namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            int passedCarsCount = 0;
            Queue<string> carQueue = new Queue<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (carQueue.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{carQueue.Dequeue()} passed!");
                            passedCarsCount++;
                        }
                    }
                    else
                    {
                        while (carQueue.Count > 0)
                        {
                            Console.WriteLine($"{carQueue.Dequeue()} passed!");
                            passedCarsCount++; 
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");
        }
    }
}