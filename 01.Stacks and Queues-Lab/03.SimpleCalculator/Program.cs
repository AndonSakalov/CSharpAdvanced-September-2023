namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> tokens = new Stack<string>(Console.ReadLine().Split().Reverse());
            int sum = int.Parse(tokens.Pop());
            while (tokens.Count > 0)
            {
                if (tokens.Peek() == "-")
                {
                    tokens.Pop();
                    sum -= int.Parse(tokens.Pop());
                }
                else if (tokens.Peek() == "+") 
                {
                    tokens.Pop();
                    sum += int.Parse(tokens.Pop());
                }
                else
                {
                   
                }
            }
            Console.WriteLine(sum);
        }
    }
}