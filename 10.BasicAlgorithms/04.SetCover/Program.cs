namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> set = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();
            int rows = int.Parse(Console.ReadLine()); //setsCount
            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] currentRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jagged[i] = currentRow.ToArray();
            }
            List<int[]> chosenSets = ChooseSets(jagged.ToList(), set.ToList()).ToList();
            Console.WriteLine($"Sets to take ({chosenSets.Count}):");
            foreach (int[] chosenSet in chosenSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", chosenSet)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> chosenSets = new List<int[]>();
            while (universe.Count > 0)
            {
                int[] longestSet = sets.OrderByDescending(s => s.Count(x => universe.Contains(x))).FirstOrDefault();
                foreach (var item in longestSet)
                {
                    universe.Remove(item);
                }

                chosenSets.Add(longestSet);
                sets.Remove(longestSet);
            }
            return chosenSets;
        }
    }
}
