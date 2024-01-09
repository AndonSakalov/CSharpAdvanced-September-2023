namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] nameAdressTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> tuple1 = new($"{nameAdressTown[0]} {nameAdressTown[1]}", nameAdressTown[2], string.Join(" ", nameAdressTown[3..]));
            string[] nameBeerBool = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, int, bool> tuple2 = new(nameBeerBool[0], int.Parse(nameBeerBool[1]), nameBeerBool[2] == "drunk");
            string[] nameBalanceBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, double, string> tuple3 = new(nameBalanceBank[0], double.Parse(nameBalanceBank[1]), nameBalanceBank[2]);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}