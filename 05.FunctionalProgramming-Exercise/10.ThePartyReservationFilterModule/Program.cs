using System.Diagnostics.Metrics;

namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invalidInvitations = new List<string>();
            Dictionary<string, Predicate<string>> filters = new();
            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] filterTokens = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = filterTokens[0];
                string filter = filterTokens[1];
                string value = filterTokens[2];
                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(filter + value))
                    {
                        filters.Add(filter + value, GetPredicate(filter, value));
                    }
                }
                else
                {
                    filters.Remove(filter + value);
                }
            }

            foreach (var filt in filters)
            {
                invitations.RemoveAll(filt.Value);
            }

            Console.WriteLine(string.Join(" ", invitations));
        }
        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    return p => p.StartsWith(value);
                    break;
                case "Ends with":
                    return p => p.EndsWith(value);
                    break;
                case "Length":
                    return p => p.Length > int.Parse(value);
                    break;
                case "Contains":
                    return p => p.Contains(value);
                    break;
                default:
                    return default;
                    break;
            }
        }
    }
}


