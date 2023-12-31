﻿namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int elementToSearch = input[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}