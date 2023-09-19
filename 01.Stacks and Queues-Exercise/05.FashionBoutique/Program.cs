namespace _05.FashionBoutique
{
    //5 4 8 6 3 8 7 7 9
    //16
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 1;
            int sum = 0;
            while (clothes.Count > 0)
            {
                int current = clothes.Pop();
                if (current + sum <= rackCapacity)
                {
                    sum += current;
                }
                else
                {
                    sum = current;
                    rackCount++;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}