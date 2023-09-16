namespace _01.Reverse_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reversedString.Push(input[i]);
            }
            while (reversedString.Count > 0)
            {
                Console.Write(reversedString.Pop());   
            }
            Console.WriteLine();
        } 
    }
}