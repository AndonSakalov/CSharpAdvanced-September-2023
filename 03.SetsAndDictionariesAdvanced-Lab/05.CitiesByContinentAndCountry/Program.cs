namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < count; i++)
            {

                string[] currentCountry = Console.ReadLine().Split();
                string continent = currentCountry[0];
                string country = currentCountry[1];
                string countryCity = currentCountry[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    continents[continent].Add(country, new List<string>());
                    continents[continent][country].Add(countryCity);
                }
                else
                {
                    if (continents[continent].ContainsKey(country))
                    {
                        continents[continent][country].Add(countryCity);
                    }
                    else
                    {
                        continents[continent].Add(country, new List<string>());
                        continents[continent][country].Add(countryCity);
                    }

                }
            }
            foreach (var kvp in continents)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"  {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
        }
    }
}