namespace _03.SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> coins = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = int.Parse(Console.ReadLine());
            coins = coins.OrderByDescending(coin => coin).ToList();
            Dictionary<int, int> coinCount = ChooseCoins(coins, sum);
            int coinsUsed = coinCount.Values.Sum();
            Console.WriteLine($"Number of coins to take: {coinsUsed}");
            foreach (var kvp in coinCount)
            {
                Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            int currentSum = 0;
            int coinIndex = 0;
            Dictionary<int, int> coinCount = new Dictionary<int, int>();
            while (currentSum < targetSum || coinIndex < coins.Count)
            {
                if (currentSum + coins[coinIndex] <= targetSum)
                {
                    if (!coinCount.ContainsKey(coins[coinIndex]))
                    {
                        coinCount.Add(coins[coinIndex], 0);
                    }
                    coinCount[coins[coinIndex]]++;
                    currentSum += coins[coinIndex];
                }
                else
                {
                    coinIndex++;
                }
            }
            if (currentSum < targetSum)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return coinCount;
            }
        }
    }
}