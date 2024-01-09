namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            foreach (double value in input)
            {
                if (!numbers.ContainsKey(value))
                {
                    numbers.Add(value, 1);
                }
                else
                {
                    numbers[value]++;
                }
            }
            foreach (KeyValuePair<double,int> number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}