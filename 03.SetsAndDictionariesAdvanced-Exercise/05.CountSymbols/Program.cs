namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
            SortedDictionary<char,int> charOccurances = new SortedDictionary<char,int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!charOccurances.ContainsKey(text[i]))
                {
                    charOccurances.Add(text[i], 0);
                }
                charOccurances[text[i]]++;
            }
            foreach (var kvp in charOccurances)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}