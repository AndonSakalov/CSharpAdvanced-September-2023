namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int readNPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < readNPeople; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }
            Person oldestFamilyMember = family.GetOldestMember();
            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}