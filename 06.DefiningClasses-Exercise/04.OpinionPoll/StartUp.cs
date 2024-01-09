namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine()); 
            Family family = new Family();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }
            List<Person> olderThan30 = family.GetOlderThan30();
            foreach (var person in olderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}