namespace _02.RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorialFromNumber(number));
        }

        static long GetFactorialFromNumber(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * GetFactorialFromNumber(number - 1);
        }
    }
}