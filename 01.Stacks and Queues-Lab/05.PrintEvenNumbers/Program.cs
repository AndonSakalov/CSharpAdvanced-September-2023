namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            while (numbers.Count > 0)
            {
                if (numbers.Peek() % 2 == 0)
                {
                    if (numbers.Count > 1)
                    {
                        Console.Write($"{numbers.Dequeue()}, ");
                    }
                    else
                    {
                        Console.WriteLine(numbers.Dequeue());
                    } 
                }
                else
                {
                    numbers.Dequeue();
                }
            }
        }
    }
}