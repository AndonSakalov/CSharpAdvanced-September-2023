namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = str => double.Parse(str);
            List<double> prices = Console.ReadLine().
                Split(", ").
                Select(parser).
                Select(pr => pr *= 1.2).
                ToList();
            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine($"{prices[i]:F2}");
            }
        }
    }
}