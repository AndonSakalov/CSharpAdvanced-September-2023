namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> printer = names => Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] commandTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandTokens[0];
                string filter = commandTokens[1];
                string value = commandTokens[2];
                if (action == "Remove")
                {
                    names.RemoveAll(GeneratePredicate(filter, value));
                }

                else
                {
                    List<string> peopleToDouble = names.FindAll(GeneratePredicate(filter, value));
                    foreach (string person in peopleToDouble)
                    {
                        int index = names.IndexOf(person);
                        names.Insert(index, person);
                    }
                }
            }

            if (names.Count > 0)
            {
                printer(names);
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static Predicate<string> GeneratePredicate(string filter, string value)
        {
            if (filter == "StartsWith")
            {
                return name => name.StartsWith(value);
            }
            else if (filter == "EndsWith")
            {
                return name => name.EndsWith(value);
            }
            else if (filter == "Length")
            {
                return name => name.Length == int.Parse(value);
            }

            return null;
        }
    }
}