namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clothCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colorClothesCount = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < clothCount; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];

                if (!colorClothesCount.ContainsKey(color))
                {
                    colorClothesCount.Add(color, new Dictionary<string, int>());
                    //for (int k = 1; k < input.Length; k++)
                    //{
                    //    colorClothesCount[color].Add(input[k], 1);
                    //}
                }

                for (int j = 1; j < input.Length; j++)
                {
                    if (!colorClothesCount[color].ContainsKey(input[j]))
                    {
                        colorClothesCount[color].Add(input[j], 0);
                    }
                    colorClothesCount[color][input[j]]++;
                }
            }
            string[] clothToSearch = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var color in colorClothesCount)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (clothToSearch[0] == color.Key && cloth.Key == clothToSearch[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}