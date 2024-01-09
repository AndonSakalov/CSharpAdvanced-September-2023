namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, string> tuple1 = new($"{nameAdress[0]} {nameAdress[1]}", nameAdress[2]);
            string[] nameBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, int> tuple2 = new(nameBeer[0], int.Parse(nameBeer[1]));
            string[] intDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<int, double> tuple3 = new(int.Parse(intDouble[0]), double.Parse(intDouble[1]));

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}