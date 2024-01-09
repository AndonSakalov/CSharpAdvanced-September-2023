namespace _05.ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            List<Person> people = new List<Person>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = personInfo[0],
                    Age = int.Parse(personInfo[1]),
                    Town = string.Join(" ", personInfo[2..])
                };

                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Person personToCompare = people[index];
            int countOfMatches = 0;
            int notEqualPeople = 0;
            foreach (var person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {notEqualPeople} {people.Count}");
            }
        }
    }
}