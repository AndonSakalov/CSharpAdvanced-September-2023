using System.Threading.Channels;

namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> openingBracketIndexes = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracketIndexes.Push(i);
                }
                if (expression[i] == ')')
                {
                    Console.WriteLine(expression.Substring(openingBracketIndexes.Peek(), i - openingBracketIndexes.Pop() + 1));
                }
            }
        }
    }
}