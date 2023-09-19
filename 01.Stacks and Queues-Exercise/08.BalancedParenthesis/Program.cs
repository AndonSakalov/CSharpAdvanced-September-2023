namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(); //input.Where(x => x == '(' || x == '{' || x == '[')
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                   stack.Push(input[i]);
                }
                if (stack.Count == 0)
                {
                    stack.Push('*');
                    break;
                }
                if (input[i] == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (input[i] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (input[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
// { [ ( ) ] }