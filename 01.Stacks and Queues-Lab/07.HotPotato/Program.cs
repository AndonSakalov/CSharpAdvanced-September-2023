namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            while (players.Count > 1)
            {
                int counter = 1;
                while (counter <= n - 1)
                {
                    string player = players.Dequeue();
                    players.Enqueue(player);
                    counter++;
                }
                Console.WriteLine($"Removed {players.Dequeue()}");
                counter = 1;
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}